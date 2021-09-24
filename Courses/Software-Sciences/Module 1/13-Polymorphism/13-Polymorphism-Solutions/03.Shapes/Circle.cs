using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; protected set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Radius * Math.PI;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
