using System;

namespace _09.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();

            switch (animalType)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}