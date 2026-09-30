namespace RobotPrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot serviceRobot1 = new ServiceRobot
            {
                ModelName = "SR-100",
                BatteryCapacity = 10,
                SoftwareVersion = "1.0",
                ServiceTask = "Assist hospital patients"
            };
            ServiceRobot serviceRobot2 =(ServiceRobot)serviceRobot1.Clone();

            serviceRobot2.BatteryCapacity = 15;
            serviceRobot2.SoftwareVersion = "2.0";

            Console.WriteLine("Original Service Robot:");
            Console.WriteLine($"Model: {serviceRobot1.ModelName}");
            Console.WriteLine($"Battery: {serviceRobot1.BatteryCapacity}");
            Console.WriteLine($"Software: {serviceRobot1.SoftwareVersion}");
            Console.WriteLine($"Task: {serviceRobot1.ServiceTask}");

            Console.WriteLine();

            Console.WriteLine("Cloned Service Robot:");
            Console.WriteLine($"Model: {serviceRobot2.ModelName}");
            Console.WriteLine($"Battery: {serviceRobot2.BatteryCapacity}");
            Console.WriteLine($"Software: {serviceRobot2.SoftwareVersion}");
            Console.WriteLine($"Task: {serviceRobot2.ServiceTask}");

            Console.WriteLine("\n-----------------------------");

            IndustrialRobot industrialRobot1 = new IndustrialRobot
            {
                ModelName = "IR-200",
                BatteryCapacity = 20,
                SoftwareVersion = "1.0",
                IndustrialTask = "Welding"
            };

            IndustrialRobot industrialRobot2 =
                (IndustrialRobot)industrialRobot1.Clone();

            industrialRobot2.BatteryCapacity = 25;
            industrialRobot2.SoftwareVersion = "1.5";

            Console.WriteLine("Original Industrial Robot:");
            Console.WriteLine($"Model: {industrialRobot1.ModelName}");
            Console.WriteLine($"Battery: {industrialRobot1.BatteryCapacity}");
            Console.WriteLine($"Software: {industrialRobot1.SoftwareVersion}");
            Console.WriteLine($"Task: {industrialRobot1.IndustrialTask}");

            Console.WriteLine();

            Console.WriteLine("Cloned Industrial Robot:");
            Console.WriteLine($"Model: {industrialRobot2.ModelName}");
            Console.WriteLine($"Battery: {industrialRobot2.BatteryCapacity}");
            Console.WriteLine($"Software: {industrialRobot2.SoftwareVersion}");
            Console.WriteLine($"Task: {industrialRobot2.IndustrialTask}");
        }
    }
}
