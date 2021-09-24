using System;
using System.Collections.Generic;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                var parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = parts[0];
                var age = int.Parse(parts[1]);

                if (parts.Length == 3)
                {
                    var group = parts[2];
                    buyers.Add(name, new Rebel(name, age, group));
                }
                else
                {
                    var id = parts[2];
                    var birthDate = parts[3];

                    buyers.Add(name, new Citizen(name, age, id, birthDate));
                }
            }

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string name = line;

                if (buyers.ContainsKey(name))
                {
                    buyers[name].BuyFood();
                }
            }
            int totalFood = 0;

            foreach (var item in buyers)
            {
                totalFood += item.Value.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
