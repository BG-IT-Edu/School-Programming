using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            int br = 0;
            while (true)
            {
                int duration = greenLight;
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (input == "green")
                {
                    string currentCar = string.Empty;
                    while (duration > 0)
                    {

                        string car = string.Empty;
                        if (queue.Count > 0)
                        {
                            car = queue.Dequeue();

                        }
                        else
                        {
                            break;
                        }

                        duration -= car.Length;
                        br++;
                        currentCar = car;
                    }

                    if (duration < 0)
                    {
                        duration = Math.Abs(duration);
                        if (duration > freeWindow)

                        {
                            duration -= freeWindow;
                            Console.WriteLine("Crash on the crossroad!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length - duration]}.");
                            return;

                        }

                    }

                }
                else
                {
                    queue.Enqueue(input);
                }

            }
            Console.WriteLine("No crash happened.");
            Console.WriteLine($"{br} total cars passed the crossroads.");
        }
    }
}
