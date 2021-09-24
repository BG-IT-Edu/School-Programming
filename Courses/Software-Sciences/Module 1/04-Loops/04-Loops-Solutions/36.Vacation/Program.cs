using System;

namespace _36.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int spendDays = 0;
            int days = 0;
            bool isManaged = true;

            while (excursionPrice > budget)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;

                if (action == "spend")
                {
                    spendDays++;
                    if (spendDays == 5)
                    {
                        isManaged = false;
                        break;
                    }

                    budget -= money;
                    if (budget < 0)
                    {
                        budget = 0;
                    }
                }
                else if (action == "save")
                {
                    spendDays = 0;
                    budget += money;
                }
            }

            if (isManaged)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
        }
    }
}