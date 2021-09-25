using System;

namespace _17.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int numbers = int.Parse(input);
                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNumber);
        }
    }
}