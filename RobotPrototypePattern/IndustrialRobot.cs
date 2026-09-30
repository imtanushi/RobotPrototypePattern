using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototypePattern
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

    }
}
