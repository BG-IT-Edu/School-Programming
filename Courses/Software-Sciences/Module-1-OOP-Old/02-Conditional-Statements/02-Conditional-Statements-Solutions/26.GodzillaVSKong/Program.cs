using System;

namespace _26.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int numOfPeople = int.Parse(Console.ReadLine());
            double numOfClothesForPerson = double.Parse(Console.ReadLine());

            double costForClothes = numOfPeople * numOfClothesForPerson;

            if (numOfPeople > 150)
            {
                costForClothes = costForClothes - (costForClothes * 0.1);
            }

            double costForDecor = filmBudget * 0.1;

            double finalCost = costForClothes + costForDecor;

            if (filmBudget >= finalCost)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - finalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalCost - filmBudget:f2} leva more.");
            }
        }
    }
}
