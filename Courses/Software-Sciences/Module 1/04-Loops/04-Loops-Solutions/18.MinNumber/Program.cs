using System;

namespace _18.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int numbers = int.Parse(input);
                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}