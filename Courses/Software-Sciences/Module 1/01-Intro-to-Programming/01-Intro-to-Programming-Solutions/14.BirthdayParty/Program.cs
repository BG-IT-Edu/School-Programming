using System;

namespace _14.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomRent = double.Parse(Console.ReadLine());

            double cake = roomRent * 0.2;
            double drinks = cake * 0.55;
            double animator = roomRent * 1 / 3;

            double price = roomRent + cake + drinks + animator;

            Console.WriteLine(price);
        }
    }
}