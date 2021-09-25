using System;

namespace _20.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            int volume = width * length * heigth;
            int boxesVolume = 0;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxesVolume += boxes;
                if (boxesVolume > volume)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(boxesVolume - volume)} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }

            if (volume >= boxesVolume)
            {
                Console.WriteLine($"{volume - boxesVolume} Cubic meters left.");
            }
        }
    }
}