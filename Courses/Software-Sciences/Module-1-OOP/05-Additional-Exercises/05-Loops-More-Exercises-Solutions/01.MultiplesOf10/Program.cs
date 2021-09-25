using System;

namespace _01.MultiplesOf10
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            while (num % 10 != 0)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", num);            
        }
    }
}