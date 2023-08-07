using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            Queue<int[]> petrolPumps = new Queue<int[]>();

            for (int i = 1; i <= countOfLines; i++)
            {
                int[] petrolPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(petrolPump);
            }

            int index = 0;

            while (true)
            {

                int totalFuel = 0;

                foreach (var petrolPumppp in petrolPumps)
                {
                    int petrolAmount = petrolPumppp[0];
                    int distance = petrolPumppp[1];

                    totalFuel += petrolAmount - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }

                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);

        }
    }
}
