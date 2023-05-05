using System;

namespace _01.ConvertToMagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var magicNumber = number * 1.5 + 40;
            Console.WriteLine(magicNumber);
        }
    }
}