using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string typeAnimal;
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Age = age;
            this.Gender = gender;
            this.Name = name;
        }
        public Animal(string typeAnimal, string name, int age, string gender)
        : this(name, age, gender)
        {
            this.TypeAnimal = typeAnimal;
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public string TypeAnimal
        {
            get { return typeAnimal; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                typeAnimal = value;
            }
        }

        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.name} {this.Age} {this.gender}");
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }
}
