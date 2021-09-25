using System;
using System.Collections.Generic;
using System.Text;

namespace LabDefiningClasses
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            this.CubicCapacity = cubicCapacity;
            this.HorsePower = horsePower;
        }

        public int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                this.horsePower = value;

            }
        }
        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }
            set
            {
                this.cubicCapacity = value;
            }
        }
    }
}
