using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Renault : ICar
    {
        public Renault(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder
                .AppendLine($"{this.Color} {nameof(Renault)} {this.Model}")
                .AppendLine($"{this.Start()}")
                .AppendLine($"{this.Stop()}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
