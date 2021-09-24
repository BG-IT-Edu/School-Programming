using System;

namespace _23.SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
            else
            {
                Console.WriteLine("ultra fast");
            }
        }
    }
}