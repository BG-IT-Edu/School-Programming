using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumtion = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumtion = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumtion = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carFuelQuantity, carFuelConsumtion, carTankCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumtion, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumtion, busTankCapacity);

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                string vehicleType = commandArgs[1];
                string value = commandArgs[2];

                if (command == "Drive")
                {
                    double distance = double.Parse(value);

                    if (vehicleType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (vehicleType == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }

                    else if (vehicleType == "Bus")
                    {
                        Console.WriteLine(bus.Drive(distance));
                    }
                }



                else if (command == "DriveEmpty")
                {
                    double distance = double.Parse(value);

                    Console.WriteLine(bus.DriveEmpty(distance));
                }

                try
                {
                    if (command == "Refuel")
                    {
                        double fuel = double.Parse(value);
                        if (vehicleType == "Car")
                        {
                            car.Refuel(fuel);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(fuel);
                        }

                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(fuel);
                        }
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
