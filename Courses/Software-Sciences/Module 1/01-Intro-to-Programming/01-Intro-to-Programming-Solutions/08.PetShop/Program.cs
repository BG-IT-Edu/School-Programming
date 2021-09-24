using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int forDogs = int.Parse(Console.ReadLine());
            int other = int.Parse(Console.ReadLine());
            Console.WriteLine($"{forDogs * 2.5 + other * 4} lv.");
        }
    }
}