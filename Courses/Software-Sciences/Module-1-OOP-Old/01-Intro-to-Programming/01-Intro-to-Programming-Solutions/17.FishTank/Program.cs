using System;

namespace _17.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumVolume = lenght * width * hight;
            double litters = aquariumVolume * 0.001;

            double neededLitter = litters * (1 - (percent * 0.01));

            Console.WriteLine(neededLitter);
        }
    }
}