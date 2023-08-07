using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> VIPguests = new HashSet<string>();
            HashSet<string> regularGuets = new HashSet<string>();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    VIPguests.Add(input);
                }
                else regularGuets.Add(input);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    VIPguests.Remove(input);
                }
                else regularGuets.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(VIPguests.Count + regularGuets.Count);


            foreach (var guest in VIPguests)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularGuets)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
