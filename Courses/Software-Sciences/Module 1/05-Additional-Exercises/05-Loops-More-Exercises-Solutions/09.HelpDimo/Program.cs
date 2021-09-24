using System;

namespace _09.HelpDimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededLength = int.Parse(Console.ReadLine());
            int startingLength = neededLength - 30;
            int countJumps = 0;
            while (startingLength <= neededLength)
            {
                for (int i = 1; i <= 3; i++)
                {
                    int jumps = int.Parse(Console.ReadLine());
                    countJumps++;
                    if (jumps > startingLength)
                    {
                        startingLength += 5;
                        break;
                    }

                    if (i == 3)
                    {
                        Console.WriteLine($"{startingLength}cm was too hard for Dimo to reach. He made {countJumps} tries.");
                        return;
                    }
                }
            }

            if (startingLength > neededLength)
            {
                Console.WriteLine($"Dimo did it, he reached his goal with {neededLength}cm. He made {countJumps} tries.");
            }
        }
    }
}