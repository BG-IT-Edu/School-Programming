using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                 .Split()
                 .ToList();

            Func<string, int, bool> CheckLength = (n, p) => n.Length == p;
            Func<string, string, bool> StartStringValidator = (n, p) => n.StartsWith(p);
            Func<string, string, bool> EndStringValidator = (n, p) => n.EndsWith(p);


            string command = Console.ReadLine();

            while (command != "Party!")
            {
                var commandInfo = command.Split();
                string commandName = commandInfo[0];
                string condition = commandInfo[1];
                string param = commandInfo[2];

                if (commandName == "Double")
                {
                    if (condition == "Length")
                    {
                        int length = int.Parse(param);
                        var temps = names.Where(x => CheckLength(x, length)).ToList();
                        InsertMyRange(names, temps);
                    }
                    else if (condition == "StartsWith")
                    {
                        var temps = names.Where(x => StartStringValidator(x, param)).ToList();
                        foreach (var name in temps)
                        {
                            int index = names.IndexOf(name);
                            names.Insert(index, name);

                        }
                    }

                    else if (condition == "EndsWith")
                    {
                        var temps = names.Where(x => EndStringValidator(x, param)).ToList();
                        foreach (var name in temps)
                        {
                            int index = names.IndexOf(name);
                            names.Insert(index, name);
                        }
                    }
                }

                else if (commandName == "Remove")
                {
                    if (condition == "Length")
                    {

                        int length = int.Parse(param);
                        names = names.Where(x => !CheckLength(x, length)).ToList();

                    }
                    else if (condition == "StartsWith")
                    {
                        names = names.Where(x => !StartStringValidator(x, param)).ToList();
                    }

                    else if (condition == "EndsWith")
                    {
                        names = names.Where(x => !EndStringValidator(x, param)).ToList();

                    }
                }


                command = Console.ReadLine();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }
        private static void InsertMyRange(List<string> names, List<string> temps)
        {
            foreach (var name in temps)
            {
                int index = names.IndexOf(name);
                names.Insert(index, name);

            }
        }
    }
}
