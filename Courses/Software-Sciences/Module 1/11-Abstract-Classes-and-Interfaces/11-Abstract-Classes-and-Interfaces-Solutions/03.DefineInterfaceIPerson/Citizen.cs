using System;
using System.Collections.Generic;
using System.Text;


namespace PersonInfo
{
    public class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name}\n{this.Age}";
        }
    }
}
