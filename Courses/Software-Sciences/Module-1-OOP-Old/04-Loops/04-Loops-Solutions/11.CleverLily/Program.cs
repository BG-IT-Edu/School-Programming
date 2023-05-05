using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundryMachine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double ageMoney = 10;
            double toysCount = 0;
            double totalSavings = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {

                    totalSavings += ageMoney - 1;
                    ageMoney += 10;
                }
                else
                {
                    toysCount++;
                }
            }

            totalSavings += toysCount * toysPrice;

            if (totalSavings >= priceLaundryMachine)
            {
                double moneyLeft = totalSavings - priceLaundryMachine;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else if (priceLaundryMachine > totalSavings)
            {
                double moneyNeeded = priceLaundryMachine - totalSavings;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}