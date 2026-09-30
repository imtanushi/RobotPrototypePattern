using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototypePattern
{
    internal class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

    }
}
