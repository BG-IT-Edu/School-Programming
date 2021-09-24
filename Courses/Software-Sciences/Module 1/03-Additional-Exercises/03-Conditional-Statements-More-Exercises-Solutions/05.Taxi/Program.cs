using System;

namespace _05.Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            string partOfDay = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double pricePerKm = 0;

            switch (month)
            {
                case "Jan":
                case "Feb":
                case "March":
                case "Apr":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.81;
                            break;
                        case "Night":
                            pricePerKm = 1.00;
                            break;
                    }

                    break;
                case "May":
                case "June":
                case "July":
                case "Aug":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.91;
                            break;
                        case "Night":
                            pricePerKm = 1.05;
                            break;
                    }

                    break;
                case "Sept":
                case "Oct":
                case "Nov":
                case "Dec":
                    switch (partOfDay)
                    {
                        case "Day":
                            pricePerKm = 0.85;
                            break;
                        case "Night":
                            pricePerKm = 1.03;
                            break;
                    }

                    break;
            }

            double totalPrice = pricePerKm * kilometers;
            Console.WriteLine("Total cost: {0:F2}lv.", totalPrice);
        }
    }
}