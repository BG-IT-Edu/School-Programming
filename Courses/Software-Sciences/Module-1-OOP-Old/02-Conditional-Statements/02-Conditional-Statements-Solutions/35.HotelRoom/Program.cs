using System;

namespace _35.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            double sumStudio = 0;
            double sumApartment = 0;
            double discount = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                sumStudio = studio * nights;
                apartment = 65;
                sumApartment = apartment * nights;
                if (nights > 7 && nights < 14)
                {
                    discount = sumStudio * 0.05;
                    sumStudio = sumStudio - discount;
                }
                else if (nights > 14)
                {
                    discount = sumStudio * 0.30;
                    sumStudio = sumStudio - discount;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                sumStudio = studio * nights;
                apartment = 68.70;
                sumApartment = apartment * nights;
                if (nights > 14)
                {
                    discount = sumStudio * 0.20;
                    sumStudio = sumStudio - discount;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                sumStudio = studio * nights;
                apartment = 77;
                sumApartment = apartment * nights;
            }

            if (nights > 14)
            {
                discount = sumApartment * 0.10;
                sumApartment = sumApartment - discount;
            }

            Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
        }
    }
}