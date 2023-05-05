using System;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaisedToPower(number, power);

            Console.WriteLine(result);
        }

        static double RaisedToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}