using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Beast!")
            {

                string[] data = Console.ReadLine().Split();

                string name = data[0];
                int age = int.Parse(data[1]);
                string gender = data[2];

                if (input == "Cat")
                {
                    var cat = new Cat(name, age, gender);
                    Console.WriteLine(cat.ProduceSound());
                }

                else if (input == "Dog")
                {
                    var dog = new Dog(name, age, gender);
                    Console.WriteLine(dog.ProduceSound());
                }

                else if (input == "Frog")
                {
                    var frog = new Frog(name, age, gender);
                    Console.WriteLine(frog.ProduceSound());
                }

                else if (input == "Kitten")
                {
                    var kitten = new Kitten(name, age);
                    Console.WriteLine(kitten.ProduceSound());
                }

                else if (input == "Tomcat")
                {
                    var tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat.ProduceSound());
                }

            }
        }
    }
}
