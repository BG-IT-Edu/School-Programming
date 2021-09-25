using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> people = new List<Employee>();
            const int AgeLimit = 30;

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                people.Add(new Employee(name, age));
            }

            var result = people
                .Where(p => p.Age > AgeLimit)
                .OrderBy(p => p.Name);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}