using System;

namespace _29.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            double totalIncome = 0;

            switch (projectionType)
            {
                case "Premiere":
                    totalIncome = (numberOfRows * numberOfColumns) * premiere;
                    break;
                case "Normal":
                    totalIncome = (numberOfRows * numberOfColumns) * normal;
                    break;
                case "Discount":
                    totalIncome = (numberOfRows * numberOfColumns) * discount;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{totalIncome:f2}");
        }
    }
}