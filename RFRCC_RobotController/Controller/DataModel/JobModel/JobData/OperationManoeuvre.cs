﻿using System;
using CopingLineModels;
using ReplaceRSConnection.Robotics;
using RFRCC_RobotController.ABB_Data;

namespace RFRCC_RobotController.Controller.DataModel.OperationData
{
    public class OperationManoeuvre
    {
        private string _Movement = "";
        private string _Type = "";
        private string _Dim2Ref = "";
        private bool _StartCut;
        private bool _EndCut;
        private bool _WristFirst;
        private int _TargetVoltage;
        private CS_RobTarget _ManRobT;
        private CS_RobTarget _ManEndRobT;
        private CS_speeddata _ManSpeed = new CS_speeddata(1000, 500, 5000, 1000);
        private CS_zonedata _ManZone = new CS_zonedata(false, 100, 150, 150, 15, 150, 15);

        public string Name { get; set; } = "";
        public CS_zonedata ManZone
        {
            get
            {
                return _ManZone;
            }
            set
            {
                _ManZone = value;
            }
        }
        public CS_speeddata ManSpeed
        {
            get
            {
                return _ManSpeed;
            }
            set
            {
                _ManSpeed = value;
            }
        }
        public CS_RobTarget ManEndRobT
        {
            get
            {
                return _ManEndRobT;
            }
            set
            {
                _ManEndRobT = value;
            }
        }
        public CS_RobTarget ManRobT
        {
            get
            {
                return _ManRobT;
            }
            set
            {
                _ManRobT = value;
            }
        }
        public bool WristFirst
        {
            get
            {
                return _WristFirst;
            }
            set
            {
                _WristFirst = value;
            }
        }
        public bool EndCut
        {
            get
            {
                return _EndCut;
            }
            set
            {
                _EndCut = value;
            }
        }
        public bool StartCut
        {
            get
            {
                return _StartCut;
            }
            set
            {
                _StartCut = value;
            }
        }
        public int TargetVoltage
        {
            get
            {
                return _TargetVoltage;
            }

            set
            {
                _TargetVoltage = value;
            }
        }
        public string Dim2Ref
        {
            get
            {
                return _Dim2Ref;
            }
            set
            {
                _Dim2Ref = value;
            }
        }
        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
        public string Movement
        {
            get
            {
                return _Movement;
            }
            set
            {
                _Movement = value;
            }
        }
        public OperationManoeuvre()
        {
            _Movement = "";
            _Type = "";
            _Dim2Ref = "";
            _StartCut = false;
            _EndCut = false;
            _WristFirst = false;
            _TargetVoltage = 0;
            _ManRobT = new CS_RobTarget();
            _ManEndRobT = new CS_RobTarget();
            _ManSpeed = new CS_speeddata();
            _ManZone = new CS_zonedata();
        }
        public OperationManoeuvre(string Input)
        {
            new OperationManoeuvre().FromString(Input);
        }
        public OperationManoeuvre(Target target)
        {

        }
        public OperationManoeuvre(MoveInstruction instruction, RobTarget toPoint, RobTarget cirPoint = null, int TargetVoltage = 0, double Speed = 0)
        {
            Name = instruction.ToPointName;
            _Movement = instruction.MotionType.ToString(); // this might need better clarification from "Joint" or "Linear"
            _Movement = _Movement == "Joint" && (cirPoint == null || cirPoint == (new RobTarget())) ? "Circle" : _Movement;
            _Type = Name.Contains("Safe") ? "Reposition" : "Cut";
            _StartCut = false;
            _EndCut = false;
            _TargetVoltage = TargetVoltage;
            _WristFirst = instruction.InstructionArguments["wristfirst"] != null && instruction.InstructionArguments["wristfirst"].Enabled;
            _ManRobT = new CS_RobTarget(toPoint);
            _ManSpeed.v_tcp = Speed > 0 ? Speed : _ManSpeed.v_tcp;
            _ManEndRobT = new CS_RobTarget(cirPoint.Frame != new RobTarget().Frame ? cirPoint : null);
        }
        public void FromString(string String)
        {
            string[] inputArray = String.Trim('[', ']').Split(',');
            _Movement = inputArray[0].ToLower().Trim('\"');
            _Type = inputArray[1].ToLower().Trim('\"');
            _Dim2Ref = inputArray[2].ToLower().Trim('\"');
            _StartCut = ABB.Robotics.Controllers.RapidDomain.Bool.Parse(inputArray[3].ToLower());
            _EndCut = ABB.Robotics.Controllers.RapidDomain.Bool.Parse(inputArray[4].ToLower());
            _WristFirst = ABB.Robotics.Controllers.RapidDomain.Bool.Parse(inputArray[5].ToLower());
            _TargetVoltage = int.Parse(inputArray[6].ToLower());
            _ManRobT.FromString(string.Join(",", inputArray[7..24]).ToLower()); // 17 variables
            _ManEndRobT.FromString(string.Join(",", inputArray[24..41]).ToLower()); // 17 variables
            _ManSpeed.FromString(string.Join(",", inputArray[41..45]).ToLower()); // 4 variables
            _ManZone.FromString(string.Join(",", inputArray[45..52]).ToLower()); // 7 varables
        }
        public override string ToString()
        {
            return "[\"" +
               _Movement + "\",\"" +
               _Type + "\",\"" +
               _Dim2Ref + "\"," +
               _StartCut.ToString() + "," +
               _EndCut.ToString() + "," +
               _WristFirst.ToString() + "," +
               _TargetVoltage.ToString() + "," +
               _ManRobT.ToString() + "," +
               _ManEndRobT.ToString() + "," +
               _ManSpeed.ToString() + "," +
               _ManZone.ToString() + "]";
        }
        public OperationManoeuvre Clone()
        {
            return (OperationManoeuvre)this.MemberwiseClone();
        }
    }
}
