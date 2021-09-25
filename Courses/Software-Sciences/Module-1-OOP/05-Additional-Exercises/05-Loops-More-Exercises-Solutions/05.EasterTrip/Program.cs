using System;

namespace _05.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numOfNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;

            switch (destination)
            {
                case "France":
                    switch (dates)
                    {
                        case "21-23":
                            pricePerNight = 30;
                            break;
                        case "24-27":
                            pricePerNight = 35;
                            break;
                        case "28-31":
                            pricePerNight = 40;
                            break;
                    }

                    break;
                case "Italy":
                    switch (dates)
                    {
                        case "21-23":
                            pricePerNight = 28;
                            break;
                        case "24-27":
                            pricePerNight = 32;
                            break;
                        case "28-31":
                            pricePerNight = 39;
                            break;
                    }

                    break;
                case "Germany":
                    switch (dates)
                    {
                        case "21-23":
                            pricePerNight = 32;
                            break;
                        case "24-27":
                            pricePerNight = 37;
                            break;
                        case "28-31":
                            pricePerNight = 43;
                            break;
                    }

                    break;
            }

            double total = numOfNights * pricePerNight;
            Console.WriteLine($"Easter trip to {destination} : {total:f2} leva.");
        }
    }
}