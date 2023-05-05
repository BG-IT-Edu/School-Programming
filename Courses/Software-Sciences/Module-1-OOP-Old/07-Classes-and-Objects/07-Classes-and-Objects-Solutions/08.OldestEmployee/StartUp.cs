using System;

namespace OldestEmployee
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Department family = new Department();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine().Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                family.AddMember(new Employee(name, age));
            }

            Employee oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}