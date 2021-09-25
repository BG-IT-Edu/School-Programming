using System;

namespace _37.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int homeSteps = 0;

            while (true)
            {
                string stepsCounter = Console.ReadLine();
                if (stepsCounter == "Going home")
                {
                    homeSteps = int.Parse(Console.ReadLine());
                    totalSteps += homeSteps;
                    if (totalSteps < 10000)
                    {
                        Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                    }
                    else if (totalSteps >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!");
                        Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                        break;
                    }

                    break;
                }

                int steps = int.Parse(stepsCounter);
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                    break;
                }
            }
        }
    }
}