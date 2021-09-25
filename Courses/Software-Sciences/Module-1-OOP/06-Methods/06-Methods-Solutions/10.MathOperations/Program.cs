using System;

namespace _10.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double b = int.Parse(Console.ReadLine());

            double result = calculate(a, command, b);

            Console.WriteLine($"{result}");
        }

        static double calculate(double a, string command, double b)
        {
            double result = 0;

            switch (command)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }

            return result;
        }
    }
}