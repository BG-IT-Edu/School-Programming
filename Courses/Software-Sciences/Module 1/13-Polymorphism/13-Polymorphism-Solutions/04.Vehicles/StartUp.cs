using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            var carInput = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
            vehicles.Add(car);

            var truckInput = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));
            vehicles.Add(truck);

            var inputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputLines; i++)
            {
                var actionInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var action = actionInput[0];
                var vehicle = actionInput[1];
                if (action == "Drive")
                {
                    var km = double.Parse(actionInput[2]);
                    DriveAction(vehicles, vehicle, km);
                }
                else if (action == "Refuel")
                {
                    var liters = double.Parse(actionInput[2]);

                    RefuleAction(vehicles, vehicle, liters);
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.GetType().Name}: {vehicle.FuelQuantity:f2}");
            }
        }

        private static void RefuleAction(List<IVehicle> vehicles, string vehicleType, double liters)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.GetType().Name == vehicleType)
                {
                    vehicle.Refuel(liters);
                }
            }
        }

        private static void DriveAction(List<IVehicle> vehicles, string vehicleType, double km)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.GetType().Name == vehicleType)
                {
                    if (vehicle.Drive(km))
                    {
                        Console.WriteLine($"{vehicleType} travelled {km} km");
                    }
                    else
                    {
                        Console.WriteLine($"{vehicleType} needs refueling");
                    }
                }
            }
        }
    }
    
}
