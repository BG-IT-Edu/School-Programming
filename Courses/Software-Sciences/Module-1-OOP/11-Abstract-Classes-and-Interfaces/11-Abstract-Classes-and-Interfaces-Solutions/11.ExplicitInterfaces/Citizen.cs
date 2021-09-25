using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson
    {
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get; private set; }
        public string Country { get; private set; }
        public int Age { get; private set; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs ";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
