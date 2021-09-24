using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1Drivers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Driver> drivers = new List<Driver>();

            int countDrivers = int.Parse(Console.ReadLine());
            for (int i = 0; i < countDrivers; i++)
            {
                string[] driverInfo = Console.ReadLine().Split();

                string driverName = driverInfo[0] + " " + driverInfo[1];
                int driverAge = int.Parse(driverInfo[2]);
                double driverTotalTime = double.Parse(driverInfo[3]);
                double driverSpeed = double.Parse(driverInfo[4]);

                Driver currentDriver = new Driver(driverName, driverAge, driverTotalTime, driverSpeed);
                drivers.Add(currentDriver);

            }

            drivers = drivers.OrderBy(x => x.TotalTime).ToList();
            Console.WriteLine(drivers[0]);

            //            Solution without overwriting the ToString method:

            //StringBuilder builder = new StringBuilder();

            //builder.AppendLine($"<DriverName>: {drivers[0].Name}");
            //builder.AppendLine($"  <DriverAge>: {drivers[0].Age}");
            //builder.AppendLine($"    Time: {drivers[0].TotalTime}");
            //builder.AppendLine($"    Speed: {drivers[0].Speed}");
            //Console.WriteLine(builder);
        }
    }
}