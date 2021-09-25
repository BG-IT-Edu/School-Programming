using System;

namespace _42.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primesSum = 0;
            int nonPrimesSum = 0;

            string input = Console.ReadLine();
            while (input != "stop")
            {
                int numbers = int.Parse(input);
                bool isNumberPrime = true;

                if (numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i <= numbers; i++)
                    {
                        if (numbers % i == 0 && i != numbers)
                        {
                            isNumberPrime = false;
                            break;
                        }
                    }

                    if (isNumberPrime == true)
                    {
                        primesSum += numbers;
                    }
                    else if (isNumberPrime == false)
                    {
                        nonPrimesSum += numbers;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: { primesSum}");
            Console.WriteLine($"Sum of all non prime numbers is: { nonPrimesSum}");
        }
    }
}