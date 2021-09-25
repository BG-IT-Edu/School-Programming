using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthDate> birthDays = new List<IBirthDate>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = parts[0];

                if (type == "Citizen")
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];

                    birthDays.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == "Pet")
                {
                    string name = parts[1];
                    string bithdate = parts[2];

                    birthDays.Add(new Pet(name, bithdate));
                }
            }

            string year = Console.ReadLine();

            var filteredBirthDays = birthDays.Where(x => x.BirthDate.EndsWith(year)).ToList();

            foreach (var birthday in filteredBirthDays)
            {
                Console.WriteLine(birthday.BirthDate);
            }
        }
    }
}
