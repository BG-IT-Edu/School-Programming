using System;

namespace _24.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "m" && output == "cm")
            {
                number = number * 100;

            }
            else if (input == "m" && output == "mm")
            {
                number = number * 1000;
            }
            else if (input == "cm" && output == "m")
            {
                number = number / 100;
            }
            else if (input == "cm" && output == "mm")
            {
                number = number * 10;
            }
            else if (input == "mm" && output == "cm")
            {
                number = number / 10;

            }
            else if (input == "mm" && output == "m")
            {
                number = number / 1000;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}