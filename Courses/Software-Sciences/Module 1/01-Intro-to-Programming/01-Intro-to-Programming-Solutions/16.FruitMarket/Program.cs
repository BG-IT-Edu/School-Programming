using System;

namespace _16.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());

            double bannanaKG = double.Parse(Console.ReadLine());
            double orangeKG = double.Parse(Console.ReadLine());
            double raspberryKG = double.Parse(Console.ReadLine());
            double strawberryKG = double.Parse(Console.ReadLine());

            double priceRaspberry = priceStrawberry / 2;
            double priceOrange = priceRaspberry * 0.6;
            double priceBannana = priceRaspberry * 0.2;

            double totalSum = (bannanaKG * priceBannana) + (orangeKG * priceOrange) + (raspberryKG * priceRaspberry) + (strawberryKG * priceStrawberry);

            Console.WriteLine(totalSum);

            //цената на малините е на половина по-ниска от тази на ягодите
            //цената на портокалите е с 40 % по - ниска от цената на малините
            //цената на бананите е с 80 % по - ниска от цената на малините
        }
    }
}