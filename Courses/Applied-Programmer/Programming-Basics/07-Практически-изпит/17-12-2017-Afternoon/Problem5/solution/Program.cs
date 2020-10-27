using System;

namespace ESDT_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var innerDashes = 0;
            var dashLeftRight = n;
            var spaces = n*2;
         
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write(new string('\\', dashLeftRight));
                Console.Write(new string('-', innerDashes));
                Console.Write(new string('-', innerDashes));
                Console.Write(new string('/', dashLeftRight));
                Console.Write(new string(' ', spaces));
                Console.WriteLine();

                innerDashes += 3;
                dashLeftRight--;
                spaces -= 2;
            }

            for (int i = 1; i < n/2; i++)
            {
                    Console.Write("|");
                    Console.Write(new string('-', n - 1));
                    Console.Write(new string('#', n*2));
                    Console.Write(new string('#', n*2));
                    Console.Write(new string('-', n - 1));
                    Console.WriteLine("|");
            }

            Console.Write("|");
            Console.Write(new string('~', n - 1));
            Console.Write(new string('/', n * 2 -3));
            Console.Write(" ESTD ");
            Console.Write(new string('\\', n * 2 -3));
            Console.Write(new string('~', n - 1));
            Console.WriteLine("|");

            for (int i = 1; i < n / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('-', n - 1));
                Console.Write(new string('#', n * 2));
                Console.Write(new string('#', n * 2));
                Console.Write(new string('-', n - 1));
                Console.WriteLine("|");
            }

            for (int i = 0; i < n; i++)
            {
                innerDashes -= 3;
                dashLeftRight++;
                spaces += 2;
                Console.Write(new string(' ', spaces));
                Console.Write(new string('/', dashLeftRight));
                Console.Write(new string('-', innerDashes));
                Console.Write(new string('-', innerDashes));
                Console.Write(new string('\\', dashLeftRight));
                Console.WriteLine();

                
            }
        }
    }
}
