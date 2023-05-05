using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();

            while (line[0] != "End")
            {
                string name = line[0];
                string country = line[1];
                int age = int.Parse(line[2]);

                IPerson person1 = new Citizen(name, country, age);
                IResident resident = new Citizen(name, country, age);

                Console.WriteLine(person1.GetName());
                Console.WriteLine(resident.GetName() + person1.GetName());

                line = Console.ReadLine().Split();
            }
        }
    }
}
