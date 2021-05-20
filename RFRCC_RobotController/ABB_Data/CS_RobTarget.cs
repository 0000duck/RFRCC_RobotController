﻿using System;
using ABB.Robotics.Controllers.RapidDomain;

namespace RFRCC_RobotController.ABB_Data
{
    public class CS_RobTarget
    {
        public CS_pos trans { get; set; }
        public CS_orient rot { get; set; }
        public CS_confdata robconf { get; set; }
        public CS_extjoint extax { get; set; }

        public CS_RobTarget()
        {
            trans = new CS_pos();
            rot = new CS_orient();
            robconf = new CS_confdata();
            extax = new CS_extjoint();
        }
        public CS_RobTarget(bool[] ExtAx)
        {
            trans = new CS_pos();
            rot = new CS_orient();
            robconf = new CS_confdata();
            extax = new CS_extjoint(ExtAx);
        }
        public CS_RobTarget(string input)
        {
            string[] inputArray = input.Trim('[', ']').Split(new string[] { "],[" }, StringSplitOptions.None);
            trans = new CS_pos(inputArray[0]);
            rot = new CS_orient(inputArray[1]);
            robconf = new CS_confdata(inputArray[2]);
            extax = new CS_extjoint(inputArray[3]);
        }
        public CS_RobTarget(DataNode[] input)
        {
            trans = new CS_pos(Single.Parse(input[0].Children[0].Value), Single.Parse(input[0].Children[1].Value), Single.Parse(input[0].Children[2].Value));
            rot = new CS_orient(Single.Parse(input[1].Children[0].Value), Single.Parse(input[1].Children[1].Value), Single.Parse(input[1].Children[2].Value), Single.Parse(input[1].Children[3].Value));
            robconf = new CS_confdata(Single.Parse(input[2].Children[0].Value), Single.Parse(input[2].Children[1].Value), Single.Parse(input[2].Children[2].Value), Single.Parse(input[2].Children[3].Value));
            extax = new CS_extjoint(input[3].Children[0].Value, input[3].Children[1].Value, input[3].Children[2].Value, input[3].Children[3].Value, input[3].Children[4].Value, input[3].Children[5].Value);
        }

        public override string ToString()
        {
            return ("[" + trans.ToString() + "," + rot.ToString() + "," + robconf.ToString() + "," + extax.ToString() + "]");
        }

        public void FromString(string Input)
        {
            string[] InputArray = Input.Trim('[', ']').Split(',');
            trans.FromString(string.Join(",", InputArray[0..3]));
            rot.FromString(string.Join(",", InputArray[3..7]));
            robconf.FromString(string.Join(",", InputArray[7..11]));
            extax.FromString(string.Join(",", InputArray[11..17]));
        }
    }
}
