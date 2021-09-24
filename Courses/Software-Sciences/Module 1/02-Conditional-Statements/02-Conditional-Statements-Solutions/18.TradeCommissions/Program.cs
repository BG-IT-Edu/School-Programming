using System;

namespace _18.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double volume = double.Parse(Console.ReadLine());
            double comission = -1;
            if (town == "sofia")
            {
                if (volume >= 0 && volume <= 500)
                {
                    comission = 0.05;
                }
                if (volume > 500 && volume <= 1000)
                {
                    comission = 0.07;
                }
                if (volume > 1000 && volume <= 10000)
                {
                    comission = 0.08;
                }
                if (volume > 10000)
                {
                    comission = 0.12;
                }
            }
            else if (town == "varna")
            {
                if (volume >= 0 && volume <= 500)
                {
                    comission = 0.045;
                }
                if (volume > 500 && volume <= 1000)
                {
                    comission = 0.075;
                }
                if (volume > 1000 && volume <= 10000)
                {
                    comission = 0.1;
                }
                if (volume > 10000)
                {
                    comission = 0.13;
                }
            }
            else if (town == "plovdiv")
            {
                if (volume >= 0 && volume <= 500)
                {
                    comission = 0.055;
                }
                if (volume > 500 && volume <= 1000)
                {
                    comission = 0.08;
                }
                if (volume > 1000 && volume <= 10000)
                {
                    comission = 0.12;
                }
                if (volume > 10000)
                {
                    comission = 0.145;
                }
            }

            if (comission == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comission * volume:F2}");
            }
        }
    }
}