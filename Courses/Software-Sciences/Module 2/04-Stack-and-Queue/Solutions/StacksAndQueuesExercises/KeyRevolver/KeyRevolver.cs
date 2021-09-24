using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);

            bool isUnlocked = false;
            int bulletsCount = bullets.Count;
            int count = 0;

            while (!isUnlocked)
            {
                if (locks.Count > 0)
                {
                    if (bullets.Count > 0)
                    {
                        int bullet = bullets.Pop();
                        int @lock = locks.Peek();
                        count++;

                        if (bullet <= @lock)
                        {
                            Console.WriteLine("Bang!");
                            locks.Dequeue();
                        }
                        else if (bullet > @lock)
                        {
                            Console.WriteLine("Ping!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                        return;
                    }
                }

                if (locks.Count == 0)
                {
                    isUnlocked = true;
                }


                if (bullets.Count > 0 && count == sizeOfGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }

            int earnedMoney = intelligence - (bulletsCount - bullets.Count) * priceBullet;

            if (isUnlocked)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
        }
    }
}
