using System;

namespace _02.JuiceProducing
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var kilogramsOfApples = (a * b) * 0.4;
            var juiceBoxes = (kilogramsOfApples / 2.3);
            if (juiceBoxes >= c)
            {
                Console.WriteLine("Great job! Total boxes {0}.", Math.Floor(juiceBoxes));
            }
            else
            {
                Console.WriteLine("Not enough juice with {0} boxes less.", Math.Floor(c - juiceBoxes));
            }
        }
    }
}