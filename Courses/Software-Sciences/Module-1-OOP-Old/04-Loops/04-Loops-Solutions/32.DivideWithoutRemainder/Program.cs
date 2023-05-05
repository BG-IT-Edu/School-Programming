using System;

namespace _32.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            double percentTo2 = 0;
            double percentTo3 = 0;
            double percentTo4 = 0;

            for (int i = 1; i <= counter; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers % 2 == 0)
                {
                    percentTo2++;
                }
                if (numbers % 3 == 0)
                {
                    percentTo3++;
                }
                if (numbers % 4 == 0)
                {
                    percentTo4++;
                }
            }

            Console.WriteLine($"{(percentTo2 / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(percentTo3 / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(percentTo4 / counter * 1.00) * 100:f2}%");
        }
    }
}