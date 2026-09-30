using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototypePattern
{
    internal class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }
    }
}
