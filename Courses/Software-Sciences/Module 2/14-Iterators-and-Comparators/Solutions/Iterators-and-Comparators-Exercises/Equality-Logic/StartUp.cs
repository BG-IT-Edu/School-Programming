namespace _06.EqualityLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var set = new HashSet<Person>();
            var sortedSet = new SortedSet<Person>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToArray();

                var name = command[0];
                var age = int.Parse(command[1]);
                var person = new Person(name, age);
                set.Add(person);
                sortedSet.Add(person);
            }

            Console.WriteLine(set.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}