using System;

namespace _04.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int anualFee = int.Parse(Console.ReadLine());

            double trainers = anualFee - anualFee * 0.4;
            double clothes = trainers * 0.80;
            double basketball = clothes / 4;
            double accesories = basketball / 5;

            double totalCost = anualFee + trainers + clothes + basketball + accesories;

            Console.WriteLine($"{totalCost:f2}");
        }
    }
}