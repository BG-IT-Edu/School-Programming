using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        private double fuelConsumption;

        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get; private set;
        }

        public double FuelConsumption
        {
            get => this.fuelConsumption + 1.6;
            private set
            {
                this.fuelConsumption = value;
            }
        }

        public int TankCapacity { get; private set; }

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
            this.FuelQuantity += (litersOfFuel * 0.95);
        }
    }
}
