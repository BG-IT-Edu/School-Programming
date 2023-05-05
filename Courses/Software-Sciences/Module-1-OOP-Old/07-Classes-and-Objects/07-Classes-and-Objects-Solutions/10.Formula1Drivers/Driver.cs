using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1Drivers
{
    public class Driver
    {
        private string name;
        private int age;
        private double totalTime;
        private double speed;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Driver(string name, int age, double totalTime, double speed)
        {
            this.Name = name;
            this.Age = age;
            this.TotalTime = totalTime;
            this.Speed = speed;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"DriverName: {this.Name}");
            builder.AppendLine($"  DriverAge: {this.Age}");
            builder.AppendLine($"    Time: {this.TotalTime}");
            builder.AppendLine($"    Speed: {this.Speed}");
            return builder.ToString();
        }
    }
    
}
