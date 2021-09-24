using System;

namespace _08.Paint
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int numOfBuckets = int.Parse(Console.ReadLine());
            int price = 0;

            switch (size)
            {
                case "Large":
                    switch (color)
                    {
                        case "Red":
                            price = 116;
                            break;
                        case "Green":
                            price = 112;
                            break;
                        case "Yellow":
                            price = 109;
                            break;
                    }

                    break;
                case "Medium":
                    switch (color)
                    {
                        case "Red":
                            price = 83;
                            break;
                        case "Green":
                            price = 89;
                            break;
                        case "Yellow":
                            price = 87;
                            break;
                    }

                    break;
                case "Small":
                    switch (color)
                    {
                        case "Red":
                            price = 49;
                            break;
                        case "Green":
                            price = 48;
                            break;
                        case "Yellow":
                            price = 45;
                            break;
                    }

                    break;
            }

            double total = numOfBuckets * price;
            total -= total * 0.35;
            Console.WriteLine($"{total:f2} leva.");
        }
    }
}