﻿using ABB.Robotics.Math;
using System;
using System.Text;
using ABB.Robotics.Controllers.RapidDomain;
using System.Net;

namespace RFRCC_RobotController.ABB_Data
{
    public class OperationHeader
    {
        private int _FeatureNum;
        private double _IdealXDisplacement;
        private string _TaskCode;
        private string _Face;
        private CS_pos _LocationMin;
        private CS_pos _LocationMax;
        private int _NumInstructions;
        private int _NumManoeuvres;
        private int _ManoeuvreIndex;
        private bool _PathComplete;
        private bool _Ready;
        private bool _LeadInstruction;
        private bool _Complete;


        public bool Complete
        {
            get
            {
                return _Complete;
            }
            set
            {
                _Complete = value;
            }
        }
        public bool LeadInstruction
        {
            get
            {
                return _LeadInstruction;
            }
            set
            {
                _LeadInstruction = value;
            }
        }
        public bool Ready
        {
            get
            {
                return _Ready;
            }
            set
            {
                _Ready = value;
            }
        }
        public bool PathComplete
        {
            get
            {
                return _PathComplete;
            }
            set
            {
                _PathComplete = value;
            }
        }
        public int ManoeuvreIndex
        {
            get
            {
                return _ManoeuvreIndex;
            }
            set
            {
                _ManoeuvreIndex = value;
            }
        }
        public int NumManoeuvres
        {
            get
            {
                return _NumManoeuvres;
            }
            set
            {
                _NumManoeuvres = value;
            }
        }
        public int NumInstructions
        {
            get
            {
                return _NumInstructions;
            }
            set
            {
                _NumInstructions = value;
            }
        }
        public CS_pos LocationMax
        {
            get
            {
                return _LocationMax;
            }
            set
            {
                _LocationMax = value;
            }
        }
        public CS_pos LocationMin
        {
            get
            {
                return _LocationMin;
            }
            set
            {
                _LocationMin = value;
            }
        }
        public string Face
        {
            get
            {
                return _Face;
            }
            set
            {
                _Face = value;
            }
        }
        public string TaskCode
        {
            get
            {
                return _TaskCode;
            }
            set
            {
                _TaskCode = value;
            }
        }
        public double IdealXDisplacement
        {
            get
            {
                return _IdealXDisplacement;
            }
            set
            {
                _IdealXDisplacement = value;
            }
        }
        public int FeatureNum
        {
            get
            {
                return _FeatureNum;
            }
            set
            {
                _FeatureNum = value;
            }
        }

        public OperationHeader()
        {
            _FeatureNum = 0;
            _IdealXDisplacement = 0;
            _TaskCode = "";
            _Face = "";
            _LocationMin = new CS_pos();
            _LocationMax = new CS_pos();
            _NumInstructions = 0;
            _NumManoeuvres = 0;
            _ManoeuvreIndex = 0;
            _PathComplete = false;
            _Ready = false;
            _LeadInstruction = false;
            _Complete = false;
        }
        public OperationHeader(string input)
        {
            new OperationHeader().FromString(input);
        }

        public void FromString(string String)
        {
            string[] inputArray = String.Trim('[', ']').Split(',');
            _FeatureNum = Int32.Parse(inputArray[0].ToLower());
            _IdealXDisplacement = Double.Parse(inputArray[1].ToLower());
            _TaskCode = inputArray[2].ToLower().Trim('\"');
            _Face = inputArray[3].ToLower().Trim('\"');
            _LocationMin.FromString(string.Join(",", inputArray[4..7]).ToLower());
            _LocationMax = new CS_pos(string.Join(",", inputArray[7..10]).ToLower());
            _NumInstructions = Int32.Parse(inputArray[10].ToLower());
            _NumManoeuvres = Int32.Parse(inputArray[11].ToLower());
            _ManoeuvreIndex = Int32.Parse(inputArray[12].ToLower());
            _PathComplete = Bool.Parse(inputArray[13].ToLower());
            _Ready = Bool.Parse(inputArray[14].ToLower());
            _LeadInstruction = Bool.Parse(inputArray[15].ToLower());
            _Complete = Bool.Parse(inputArray[16].ToLower());
        }
        public override string ToString()
        {
            return "[" +
               _FeatureNum.ToString() + "," +
               _IdealXDisplacement.ToString() + ",\"" +
               _TaskCode + "\",\"" +
               _Face + "\"," +
               _LocationMin.ToString() + "," +
               _LocationMax.ToString() + "," +
               _NumInstructions.ToString() + "," +
               _NumManoeuvres.ToString() + "," +
               _ManoeuvreIndex.ToString() + "," +
               _PathComplete.ToString() + "," +
               _Ready.ToString() + "," +
               _LeadInstruction.ToString() + "," +
               _Complete.ToString() + "]";
        }

        public OperationHeader Clone()
        {
            return (OperationHeader)this.MemberwiseClone();
        }

    }
}
