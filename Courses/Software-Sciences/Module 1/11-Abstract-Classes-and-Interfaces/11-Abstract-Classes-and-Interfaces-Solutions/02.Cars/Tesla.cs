using System.Text;

namespace Cars
{
  public  class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Battery { get; set; }

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
                .AppendLine($"{this.Color} {nameof(Tesla)} {this.Model} with {this.Battery} Batteries")
                .AppendLine($"{this.Start()}")
                .AppendLine($"{this.Stop()}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
