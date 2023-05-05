using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuelConsumption;

        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption
        {
            get => this.fuelConsumption + 0.9;
            private set
            {
                this.fuelConsumption = value;
            }
        }

        public bool Drive(double km)
        {
            var fuelToUse = km * FuelConsumption;
            if (fuelToUse < FuelQuantity)
            {
                FuelQuantity -= fuelToUse;
                return true;
            }

            return false;
        }

        public void Refuel(double litersOfFuel)
        {
            this.FuelQuantity += litersOfFuel;
        }
    }
}
