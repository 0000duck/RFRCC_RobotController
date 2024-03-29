﻿using System;
using System.Collections.Generic;
using System.Text;
using RapidString = ABB.Robotics.Controllers.RapidDomain.String;
using RapidBool = ABB.Robotics.Controllers.RapidDomain.Bool;
using RFRCC_RobotController.Controller.DataModel.RAPID_Data;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.RapidDomain;
using RFRCC_RobotController.Controller.DataModel.OperationData;

namespace RFRCC_RobotController.Controller.DataModel
{
    /// <summary>
    /// Houses all project data and data connections to robot memory
    /// </summary>
    public class DataModel
    {
        private RobotController _parentController;

        // RAPID Data to be sorted
        internal RapidData SQLMessageRecieve;
        internal RapidData SQLMessageError;
        internal RapidData PCConnected;
        internal RapidData RapidJobData;
        internal RapidData RapidFeatureData;
        internal RapidData PCSDK_Complete;
        internal RapidData Robot_Status;
        /// <summary>
        /// Next job x from datum required for PLC to get job to
        /// </summary>
        public RapidData NextDX;

        /// <summary>
        /// list of job(s) to be completed
        /// </summary>
        public List<JobModel> Operations = new List<JobModel>();
        internal bool SaveJobDataOnComplete = false; // if true, save job information from robot into something...
        internal bool ClearJobDataOnComplete = true; // deletes operation information from operation list as soon as completed
        



        // TODO: update and move the below

        // Generated Path structures
        public PC_RobotMove_Register RobotInstuctionsRegister;
        public RAPID_OM_List OperationManeouvres;
        public RAPID_OH_List OperationHeaders;
        internal List<JobFeature> jobFeatureData = new List<JobFeature>();

        // Job Data Buffers
        public RAPIDJob_Header jobHeader;
        internal JobHeader jobHeaderData = new JobHeader();
        internal RAPIDJobHeader Header_JobData_RapidBuffer = new RAPIDJobHeader();
        internal RAPIDJobFeature Header_FeatureData_RapidBuffer = new RAPIDJobFeature();
        public List<JobHeader> jobHeaders = new List<JobHeader>();
        public List<JobFeature> jobFeatures = new List<JobFeature>();
        public Robot_ControlStruct Robot_Control = new Robot_ControlStruct();
        //public RAPID_OperationBuffer OperationBuffer; //  --> has been moved to JobModel
        public RAPID_CutChart TopCutChart = new RAPID_CutChart();
        public RAPID_CutChart BottomCutChart = new RAPID_CutChart();
        public RAPID_CutChart FrontCutChart = new RAPID_CutChart();
        public RAPID_CutChart BackCutChart = new RAPID_CutChart();


        public ReplaceRSConnection.Robotics.ToolInfo.ToolData ToolData;

        public DataModel(RobotController ParentController)
        {
            _parentController = ParentController;
        }

        // starts up data stream and checks that datamodel 
        // TODO: test that this function correctly identifies the robot program will work with this library
        public void InitDataStream()
        {
            bool complete = false;
            if (_parentController.tRob1 != null)
            {
                _parentController.StatusMesssageChange(this, new RobotController.StatusMesssageEventArgs("Connecting to controller"));
                SQLMessageRecieve = _parentController.tRob1.GetRapidData("SQL_Comm", "SQLMessageRecieve");
                RapidJobData = _parentController.tRob1.GetRapidData("Module1", "Sys_JobData");
                RapidFeatureData = _parentController.tRob1.GetRapidData("Module1", "Sys_FeatureData");
                PCSDK_Complete = _parentController.tRob1.GetRapidData("SQL_Comm", "PCSDK_Complete");
                SQLMessageError = _parentController.tRob1.GetRapidData("SQL_Comm", "SQLMessageError");
                PCConnected = _parentController.tRob1.GetRapidData("SQL_Comm", "PCConnected");
                Robot_Status = _parentController.tRob1.GetRapidData("Module1", "Rob_Status");

                TopCutChart.ConnectToRAPID(_parentController.controller, _parentController.tRob1, "Module1", "Top_CutChart");
                BottomCutChart.ConnectToRAPID(_parentController.controller, _parentController.tRob1, "Module1", "Bottom_CutChart");
                FrontCutChart.ConnectToRAPID(_parentController.controller, _parentController.tRob1, "Module1", "Front_CutChart");
                BackCutChart.ConnectToRAPID(_parentController.controller, _parentController.tRob1, "Module1", "Back_CutChart");

                Robot_Control.ConnectToRAPID(_parentController.controller, _parentController.tRob1, "Module1", "Rob_Control");
                OperationManeouvres = new RAPID_OM_List(99, _parentController.controller, _parentController.tRob1, "Module1", "OperationManoeuvres");
                OperationHeaders = new RAPID_OH_List(20, _parentController.controller, _parentController.tRob1, "Module1", "OperationHeaders");
                OperationBuffer = new RAPID_OperationBuffer(_parentController.controller, _parentController.tRob1, "PC_Manoeuvre_Register", "OpManPCBuffer", "PC_Manoeuvre_Register", "OpHeadPCBuffer");
                OperationBuffer.DescendingOrder = true;
                jobHeader = new RAPIDJob_Header(_parentController.controller, _parentController.tRob1, "Module1", "Sys_JobData");

                Robot_Control.ValueUpdate += _parentController.OnControlValueUpdate; // Maybe update to enable Interrupts
                Robot_Control.PC_MessageUpdate += _parentController.RobotPC_MessageChanged;

                NextDX = _parentController.tRob1.GetRapidData("Module1", "NextDX");
                NextDX.ValueChanged += _parentController.NextDXChange;

                while (!complete)
                {
                    try
                    {
                        using (Mastership m = Mastership.Request(_parentController.controller.Rapid))
                        {
                            PCConnected.Value = RapidBool.Parse("TRUE");
                        }
                    }
                    catch
                    {
                        complete = false;
                    }
                    finally
                    {
                        complete = true;
                    }
                }

            }
            else
            {
                _parentController.StatusMesssageChange(this, new RobotController.StatusMesssageEventArgs("'targets' data does not exist!"));
            }


        }
        public List<JobFeature> FeatureDataList
        {
            get { return jobFeatureData; }
            set { jobFeatureData = value; }
        }
        public JobFeature FeatureData(int index)
        {
            return jobFeatureData[index];
        }
        public JobHeader HeaderData
        {
            get { return jobHeaderData; }
            set { jobHeaderData = value; }
        }

        public void UpdateRobot(string Table, int FeatureNum = 0, int Carriage = 0)
        {
            bool complete = false;
            switch (Table.ToLower())
            {
                case "header":


                    Header_JobData_RapidBuffer.UpdatedFromSQL(HeaderData);

                    // Rewrite data to robot memory
                    while (!complete)
                    {
                        try
                        {
                            using (Mastership m = Mastership.Request(_parentController.controller.Rapid))
                            {
                                RapidJobData.StringValue = Header_JobData_RapidBuffer.ToString();
                            }
                        }
                        catch
                        {
                            complete = false;
                        }
                        finally
                        {
                            complete = true;
                        }
                    }


                    break;

                case "feature":

                    // Update Header Buffer from 1st Jobheader (assume first one is one we want)
                    foreach (JobFeature feature in FeatureDataList)
                    {
                        if (feature.FeatureNum == FeatureNum)
                        {
                            // TODO: change to internal memory?
                            Header_FeatureData_RapidBuffer.UpdatedFromSQL(feature);
                            break;
                        }
                    }

                    // Rewrite data to robot memory
                    while (!complete)
                    {
                        try
                        {
                            using (Mastership m = Mastership.Request(_parentController.controller.Rapid))
                            {
                                RapidFeatureData.StringValue = Header_FeatureData_RapidBuffer.ToString();
                            }
                        }
                        catch
                        {
                            _parentController.StatusMesssageChange(_parentController, new RobotController.StatusMesssageEventArgs("mastership failed while attempting to update Feature Data"));
                            complete = false;
                        }
                        finally
                        {
                            complete = true;
                        }
                    }

                    break;

                case "manoeuvre":

                    _parentController.StatusMesssageChange(_parentController, new RobotController.StatusMesssageEventArgs("Robot requested Manoeuvre " + FeatureNum.ToString() + ". Sending to Robot"));

                    //raise event to write manoeuvre 
                    if (_parentController.ManoeuvreUpdate(_parentController, new RobotController.ManoeuvreUpdateEventArgs(FeatureNum, Carriage, OperationBuffer)))
                    {
                        _parentController.StatusMesssageChange(_parentController, new RobotController.StatusMesssageEventArgs("Successfully transferred Manoeuvre to Robot"));
                    }
                    else
                    {
                        _parentController.StatusMesssageChange(_parentController, new RobotController.StatusMesssageEventArgs("ERROR in transfer Manoeuvre to Robot"));
                    }

                    break;

                default:
                    break;
            }


        }
        public bool UpdateRCC(string JobID)
        {
            return _parentController.OnRequestUpdatedJobData(_parentController, new RobotController.RequestUpdatedJobDataEventArgs(JobID, false));
        }





        // TODO: finish load data onto robot controller
        public bool LoadJobData(string JobData)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement load additional Jobs onto 
        public bool LoadAdditionalJobData(string JobData)
        {
            throw new NotImplementedException();
        }

        public void ClearJobData()
        {
            Operations.Clear();
        }



    }
}
