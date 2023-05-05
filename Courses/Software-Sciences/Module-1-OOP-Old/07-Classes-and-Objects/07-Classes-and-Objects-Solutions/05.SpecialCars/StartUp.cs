using LabDefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            string inputTire;
            while ((inputTire = Console.ReadLine()) != "No more tires")
            {
                string[] info = inputTire.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Tire[] tire = new Tire[4];

                for (int i = 0; i < tire.Length; i++)
                {
                    int year = int.Parse(info[i * 2]);
                    double pressure = double.Parse(info[i * 2 + 1]);

                    Tire oneTire = new Tire(year, pressure);
                    tire[i] = oneTire;
                }

                tiresList.Add(tire);
            }

            List<Engine> engineList = new List<Engine>();
            string inputEngine;
            while ((inputEngine = Console.ReadLine()) != "Engines done")
            {
                string[] info = inputEngine.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine engine = new Engine(int.Parse(info[0]), double.Parse(info[1]));
                engineList.Add(engine);
            }

            List<Car> carList = new List<Car>();

            string carInfo;
            while ((carInfo = Console.ReadLine()) != "Show special")
            {
                string[] info = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string make = info[0];
                string model = info[1];
                int year = int.Parse(info[2]);
                double fuelQuantity = double.Parse(info[3]);
                double fuelConsumtion = double.Parse(info[4]);
                Engine engine = engineList[int.Parse(info[5])];
                Tire[] tires = tiresList[int.Parse(info[6])];

                Car car = new Car(
                    make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumtion,
                    engine,
                    tires);

                carList.Add(car);
            }

            foreach (var car in carList)
            {
                Predicate<Car> yearPredicate = car => car.Year >= 2017;
                Predicate<Car> powerPredicate = car => car.Engine.HorsePower > 330;
                Predicate<Car> tiresPredicate = car =>
                car.Tires.Sum(x => x.Pressure) >= 9 &&
                car.Tires.Sum(x => x.Pressure) <= 10;

                if (yearPredicate(car) && powerPredicate(car) && tiresPredicate(car))
                {
                    var neededFuel = car.FuelConsumption * 20 / 100;
                    car.FuelQuantity -= neededFuel;

                    car.GetSpecification();
                }
            }
        }
    }
}