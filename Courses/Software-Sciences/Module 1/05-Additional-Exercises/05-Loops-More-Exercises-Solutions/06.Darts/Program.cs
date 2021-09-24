using System;

namespace _06.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsLeft = 301;
            int successfulShots = 0;
            int failedShots = 0;
            while (pointsLeft != 0)
            {
                string field = Console.ReadLine();
                if (field == "Retire")
                {
                    break;
                }
                int points = int.Parse(Console.ReadLine());
                switch (field)
                {
                    case "Single":
                        if (pointsLeft - points >= 0)
                        {
                            pointsLeft -= points;
                            successfulShots++;
                        }
                        else
                        {
                            failedShots++;
                        }

                        break;
                    case "Double":
                        if (pointsLeft - 2 * points >= 0)
                        {
                            pointsLeft -= 2 * points;
                            successfulShots++;
                        }
                        else
                        {
                            failedShots++;
                        }

                        break;
                    case "Triple":
                        if (pointsLeft - 3 * points >= 0)
                        {
                            pointsLeft -= 3 * points;
                            successfulShots++;
                        }
                        else
                        {
                            failedShots++;
                        }

                        break;
                }
            }

            if (pointsLeft == 0)
            {
                Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
            }
            else
            {
                Console.WriteLine($"{name} retired after {failedShots} unsuccessful shots.");
            }
        }
    }
}