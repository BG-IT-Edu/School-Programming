using System;
using System.Collections.Generic;
using System.Text;

namespace OpinionPoll
{
    public class Employee
    {
        private string name;
        private int age;

        public Employee()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Employee(int age) : this()
        {
            this.Age = age;
        }

        public Employee(string name, int age) : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }
    }
}
