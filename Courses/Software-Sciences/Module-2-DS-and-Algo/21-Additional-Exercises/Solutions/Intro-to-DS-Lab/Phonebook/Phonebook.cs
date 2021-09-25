using System;
using System.Linq;
using Wintellect.PowerCollections;

class Phonebook
{
    static void Main()
    {
        MultiDictionary<string, string> phoneBook = new MultiDictionary<string, string>(true);
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" - ");
            string name = input[0];
            string phoneNumber = input[1];

            phoneBook.Add(name, phoneNumber);
        }

        foreach (var kvp in phoneBook.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
