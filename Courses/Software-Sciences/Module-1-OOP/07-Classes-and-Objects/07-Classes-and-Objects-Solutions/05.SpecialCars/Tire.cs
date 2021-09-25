using System;
using System.Collections.Generic;
using System.Text;

namespace LabDefiningClasses
{
    public class Tire
    {
        private int year;
        private double pressure;

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }
        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                this.pressure = value;

            }
        }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
