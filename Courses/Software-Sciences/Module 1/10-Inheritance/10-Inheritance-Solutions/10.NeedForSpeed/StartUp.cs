using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string vehicleType = Console.ReadLine();
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double kmDrive = double.Parse(Console.ReadLine());

            switch (vehicleType)
            {
                case "Vehicle":
                    Vehicle vehicle = new Vehicle(horsePower, fuel);
                    vehicle.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {vehicle.Fuel:f2}");
                    break;

                case "Motorcycle":
                    Motorcycle motorcycle = new Motorcycle(horsePower, fuel);
                    motorcycle.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {motorcycle.Fuel:f2}");
                    break;

                case "Car":
                    Car car = new Car(horsePower, fuel);
                    car.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {car.Fuel:f2}");
                    break;

                case "RaceMotorcycle":
                    RaceMotorcycle raceMotorcycle = new RaceMotorcycle(horsePower, fuel);
                    raceMotorcycle.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {raceMotorcycle.Fuel:f2}");
                    break;

                case "CrossMotorcycle":
                    CrossMotorcycle crossMotorcycle = new CrossMotorcycle(horsePower, fuel);
                    crossMotorcycle.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {crossMotorcycle.Fuel:f2}");
                    break;

                case "FamilyCar":
                    FamilyCar familyCar = new FamilyCar(horsePower, fuel);
                    familyCar.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {familyCar.Fuel:f2}");
                    break;

                case "SportCar":
                    SportCar sportCar = new SportCar(horsePower, fuel);
                    sportCar.Drive(kmDrive);
                    Console.WriteLine($"Left fuel {sportCar.Fuel:f2}");
                    break;

            }
        }
    }
}
