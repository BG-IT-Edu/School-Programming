using System;

namespace _13.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();

            string passwordInput = Console.ReadLine();
            while (passwordInput != password)
            {
                passwordInput = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {user}!");
        }
    }
}