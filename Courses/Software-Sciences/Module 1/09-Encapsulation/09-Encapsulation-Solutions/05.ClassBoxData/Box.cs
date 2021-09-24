using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    this.width = 0;

                    throw new Exception("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }

            }
        }

        private double SurfaceArea()
        {
            double result = 0;
            result += 2 * this.length * this.width;
            result += 2 * this.length * this.height;
            result += 2 * this.width * this.height;
            return result;
        }

        private double LateralSurfaceArea()
        {
            //2lh + 2wh
            double result = 0;
            result += 2 * this.length * this.height;
            result += 2 * this.width * this.height;
            return result;
        }

        private double Volume()
        {
            double result = 0;
            result += this.length * this.width * this.height;
            return result;
        }

        public override string ToString()
        {
            string result = $"Surface Area - {SurfaceArea():F2}\n";
            result += $"Lateral Surface Area - {LateralSurfaceArea():F2}\n";
            result += $"Volume - {Volume():F2}";
            return result;
        }
    }
}
