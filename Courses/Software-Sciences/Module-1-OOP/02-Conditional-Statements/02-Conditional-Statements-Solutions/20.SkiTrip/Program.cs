using System;

namespace _20.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string rate = Console.ReadLine();

            int nights = days - 1;
            double price = 18 * nights;

            if (kindOfRoom == "apartment")
            {
                price = 25 * nights;
                if (days < 10)
                {
                    price = price - 0.3 * price;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - 0.35 * price;
                }
                else if (days > 15)
                {
                    price = price - 0.5 * price;
                }
            }
            else if (kindOfRoom == "president apartment")
            {
                price = 35 * nights;
                if (days < 10)
                {
                    price = price - 0.1 * price;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = price - 0.15 * price;
                }
                else if (days > 15)
                {
                    price = price - 0.2 * price;
                }
            }

            if (rate == "positive")
            {
                price = price + 0.25 * price;
            }
            else if (rate == "negative")
            {
                price = price - 0.1 * price;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}