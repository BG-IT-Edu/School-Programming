using System;

namespace _15.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number;)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }
        }
    }
}