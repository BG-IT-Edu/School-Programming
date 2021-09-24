using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Child(string name, int age, Person mother, Person father)
            : base(name, age)
        {
            this.Mother = mother;
            this.Father = father;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format(base.ToString() + 
                $", Mother: {this.Mother.Name}, Father: {this.Father.Name}"));

            return stringBuilder.ToString();
        }
    }
}
