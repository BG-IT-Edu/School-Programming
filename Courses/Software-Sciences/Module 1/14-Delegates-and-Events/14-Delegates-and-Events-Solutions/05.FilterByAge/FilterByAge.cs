using System;
using System.Collections.Generic;

namespace FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < peopleCount; i++)
            {
                var person = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                people.Add(person[0], int.Parse(person[1]));
            }

            string condition = Console.ReadLine();
            int compareAge = int.Parse(Console.ReadLine());
            string outputFormat = Console.ReadLine();

            var filter = CreateFilter(condition, compareAge);
            var write = CreateWriter(outputFormat);

            foreach (var kv in people)
            {
                if (filter(kv.Value))
                {
                    write(kv);
                }
            }
        }
        static Func<int, bool> CreateFilter(string condition, int compareAge)
        {
            if (condition == "older")
            {
                return x => x >= compareAge;
            }

            return x => x < compareAge;
        }

        static Action<KeyValuePair<string, int>> CreateWriter(string outputFormat)
        {
            switch (outputFormat)
            {
                case "name":
                    return x => Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                default:
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
            }
        }
    }
}
