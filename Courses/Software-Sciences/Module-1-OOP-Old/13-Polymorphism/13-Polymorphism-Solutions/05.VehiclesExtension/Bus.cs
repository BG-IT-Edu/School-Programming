using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
   public class Bus : Vehicle
    {
        private const double AdditionConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + AdditionConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= AdditionConsumption;

            return Drive(distance);
        }
    }
}
