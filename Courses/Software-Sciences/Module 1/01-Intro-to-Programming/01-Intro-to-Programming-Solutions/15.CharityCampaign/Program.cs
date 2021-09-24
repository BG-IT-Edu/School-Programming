using System;

namespace _15.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int corrugations = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double totalSum = days * chefs * (cakes * 45 + corrugations * 5.80 + pancakes * 3.20);

            double totalCharity = totalSum * 7 / 8;

            Console.WriteLine(totalCharity);
        }
    }
}