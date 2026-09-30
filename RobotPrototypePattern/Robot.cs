using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototypePattern
{
    public abstract class Robot
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        public abstract Robot Clone();
    }
}
