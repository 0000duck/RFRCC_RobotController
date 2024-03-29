﻿using ReplaceRSConnection.Robotics.ToolInfo;
using RFRCC_RobotController.Controller.DataModel.OperationData;
using RFRCC_RobotController.Controller.DataModel.RAPID_Data;
using RFRCC_RobotController.Controller.Importers;
using System;
using System.Text;

namespace RFRCC_RobotController.Controller.DataModel
{
    /* TODO: list for operation models
     *      X add 'job header' to encapsulate job information
     *      o add method to input data obtained from import process
     *      o add template of job execution (including PLC requirements and such)
     *      o 
     */
    /// <summary>
    /// Model of job operation file containing all processes and information on current job processing
    /// </summary>
    public class JobModel
    {
        private RobotController _parentController;
        private bool _controllerPresent = false;
        private string _filename;
        private string _filepath;
        private OperationActionList _operationActions = new OperationActionList();
        private int _NumFeatures;
        private bool _StartedProcessing;
        private bool _FinishedProcessing;
        private bool _ReadyforProcessing;

        // Job specific Data
        internal RAPID_OperationBuffer OperationRobotMoveData;  // previously 'OperationBuffer'



        public string ProjectStatus { get; set; }
        public JobHeader HeaderInfo { get; set; }
        public ToolData ToolData { get; set; } = new ToolData();

        public JobModel()
        {

        }
        public JobModel(RobotController ParentController, int index = -1)
        {
            _parentController = ParentController;
            _controllerPresent = true;
            // TODO: check connection active and associate this file with controller

            if (index == -1) _parentController.dataModel.Operations.Add(this);
            else _parentController.dataModel.Operations.Insert(index, this);
        }
        /// <summary>
        /// Connects to a controller and insert Job in list of jobs to be completed
        /// </summary>
        /// <param name="ParentController">Controller to be connected to</param>
        /// <param name="index">Job index in list to be completed if known</param>
        /// <returns></returns>
        public bool ConnectParentController(RobotController ParentController, int index = -1)
        {
            if (_controllerPresent)
            {
                // TODO: check if need to do extra steps to change pointer
                _parentController = ParentController;
                // TODO: check connection active and associate this file with controller
            }
            else
            {
                _parentController = ParentController;
                _controllerPresent = true;
                // TODO: check connection active and associate this file with controller
            }

            if (index == -1) _parentController.dataModel.Operations.Add(this);
            else _parentController.dataModel.Operations.Insert(index, this);
            return true; // return false if failed to connect
        }
        // TODO: setup Load Job information from file import

        public bool LoadJobFromFile(string Filename, bool Parse)
        {
            _filename = Filename;
            if (Parse)
            {

            }
            throw new NotImplementedException();
        }
        public bool LoadJobFromParser(FileImporter Parser)
        {

            throw new NotImplementedException();
        }

    }
}
