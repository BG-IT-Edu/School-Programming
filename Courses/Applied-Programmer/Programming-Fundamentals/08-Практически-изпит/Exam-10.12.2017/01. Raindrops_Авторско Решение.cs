using System;

namespace _01._Raindrops
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //We read N
            int n = int.Parse(Console.ReadLine());

            //The density is a floating-point number, with no specified precision
            //Thats why we use the most precise, to ensure all possible cases
            //Decimal!
            decimal density = decimal.Parse(Console.ReadLine());

            //The sum of all coefficients should be a decimal, by problem description
            decimal totalRainCoefficient = 0M;

            //Just a simple loop
            for (int i = 0; i < n; i++)
            {
                //Read and split parameters
                string[] regionParameters = Console.ReadLine().Split();

                //Parse parameters
                //raindrops count -> from -2^31 to 2^31 (int.MaxValue = 2^31 - 1), so we use long
                long raindropsCount = long.Parse(regionParameters[0]);
                int squareMeters = int.Parse(regionParameters[1]);

                //Calculate the regionRainCoefficient and add it to the total
                totalRainCoefficient += (raindropsCount / (decimal)squareMeters);
            }

            //Check if a division is possible. The only case where it is not possible, is when density == 0
            if (density != 0)
            {
                totalRainCoefficient = totalRainCoefficient / density;
            }

            //Print till third digit after decimal point
            Console.WriteLine($"{totalRainCoefficient:F3}");
        }
    }
}
