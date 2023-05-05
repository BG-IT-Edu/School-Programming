using System;

namespace _34.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int check = 0;

            string input = Console.ReadLine();
            while (input != "No More Books")
            {

                if (input == favoriteBook)
                {
                    Console.WriteLine($"You checked {check} books and found it.");
                    break;
                }

                check++;
                input = Console.ReadLine();
            }

            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {check} books.");
            }
        }
    }
}