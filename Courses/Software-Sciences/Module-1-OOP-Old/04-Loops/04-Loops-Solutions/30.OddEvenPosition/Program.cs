using System;

namespace _30.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double sumEven = 0;
            double maxEven = -1000000000.0;
            double minEven = 1000000000.0;
            double sumOdd = 0;
            double maxOdd = -1000000000.0;
            double minOdd = 1000000000.0;

            for (int i = 0; i < count; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOdd += numbers;
                    if (numbers > maxOdd)
                    {
                        maxOdd = numbers;
                    }

                    if (numbers < minOdd)
                    {
                        minOdd = numbers;
                    }
                }
                else
                {
                    sumEven += numbers;
                    if (numbers > maxEven)
                    {
                        maxEven = numbers;
                    }

                    if (numbers < minEven)
                    {
                        minEven = numbers;
                    }
                }
            }

            Console.WriteLine($"OddSum={sumOdd:f2},");
            if (count > 0)
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }

            Console.WriteLine($"EvenSum={sumEven:f2},");
            if (count > 1)
            {

                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}