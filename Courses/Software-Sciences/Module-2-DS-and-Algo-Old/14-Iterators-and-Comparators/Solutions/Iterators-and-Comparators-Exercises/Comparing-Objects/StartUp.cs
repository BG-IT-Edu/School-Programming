namespace _05.ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            while (true)
            {
                var command = Console.ReadLine().Split().ToArray();

                if (command[0] == "END")
                {
                    var positionOfPersonToCompare = int.Parse(Console.ReadLine()) - 1;
                    var matches = 0;

                    for (int i = 0; i < people.Count; i++)
                    {
                        var currentPerson = people[i];

                        if (currentPerson.CompareTo(people[positionOfPersonToCompare]) == 0)
                        {
                            matches++;
                        }
                    }

                    if (matches > 1)
                    {
                        var totalNumberOfPeople = people.Count;
                        var numberOfNotEqualPeople = totalNumberOfPeople - matches;
                        Console.WriteLine($"{matches} {numberOfNotEqualPeople} {totalNumberOfPeople}");
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }

                    return;
                }

                var name = command[0];
                var age = int.Parse(command[1]);
                var town = command[2];
                var person = new Person(name, age, town);
                people.Add(person);
            }
        }
    }
}