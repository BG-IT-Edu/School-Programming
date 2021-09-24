using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservation
{
    class PartyReservation
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split()
                .ToList();
            var originalNames = names;
            Func<string, string, bool> StartsWithFilter = (n, p) => (n.StartsWith(p));
            Func<string, string, bool> EndsWithFilter = (n, p) => (n.EndsWith(p));
            Func<string, string, bool> ContainsFilter = (n, p) => (n.Contains(p));
            Func<string, int, bool> LengthFilter = (n, p) => (n.Length == p);
            Dictionary<string, List<string>> listFilters = new Dictionary<string, List<string>>();


            Action<List<string>> PrintNames = names => Console.WriteLine(string.Join(" ", names));

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Print")
                {
                    break;
                }

                else
                {
                    var command = input.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var filterName = command[0];
                    var filterType = command[1];
                    var filterParameter = command[2];


                    if (filterName == "Add filter")
                    {
                        if (filterType == "Starts with")
                        {
                            if (!listFilters.ContainsKey(filterType))
                            {
                                listFilters.Add(filterType, new List<string>());
                            }

                            listFilters[filterType].Add(filterParameter);

                        }
                        else if (filterType == "Ends with")
                        {
                            if (!listFilters.ContainsKey(filterType))
                            {
                                listFilters.Add(filterType, new List<string>());
                            }

                            listFilters[filterType].Add(filterParameter);
                        }

                        else if (filterType == "Length")
                        {
                            if (!listFilters.ContainsKey(filterType))
                            {
                                listFilters.Add(filterType, new List<string>());
                            }

                            listFilters[filterType].Add(filterParameter);

                        }

                        else if (filterType == "Contains")
                        {
                            if (!listFilters.ContainsKey(filterType))
                            {
                                listFilters.Add(filterType, new List<string>());
                            }

                            listFilters[filterType].Add(filterParameter);
                        }
                    }
                    else if (filterName == "Remove filter")
                    {
                        if (listFilters[filterType].Contains(filterParameter))
                        {
                            listFilters[filterType].Remove(filterParameter);

                        }

                    }

                }
            }

            if (listFilters.ContainsKey("Starts with"))
            {
                foreach (var filter in listFilters)
                {
                    foreach (var item in filter.Value)
                    {
                        names = names.Where(x => !StartsWithFilter(x, item)).ToList();
                    }
                }
            }
            if (listFilters.ContainsKey("Ends with"))
            {
                foreach (var filter in listFilters)
                {
                    foreach (var item in filter.Value)
                    {
                        names = names.Where(x => !EndsWithFilter(x, item)).ToList();
                    }
                }
            }
            if (listFilters.ContainsKey("Contains"))
            {
                foreach (var filter in listFilters)
                {
                    foreach (var item in filter.Value)
                    {
                        names = names.Where(x => !ContainsFilter(x, item)).ToList();
                    }
                }
            }
            if (listFilters.ContainsKey("Length"))
            {
                foreach (var filter in listFilters.Where(x => x.Key == "Length"))
                {
                    foreach (var item in filter.Value)
                    {
                        names = names.Where(x => !LengthFilter(x, int.Parse(item))).ToList();
                    }
                }
            }

            PrintNames(names);

        }
    }
}
