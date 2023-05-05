using System;

namespace _27.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCounter = 0;
            int standartCounter = 0;
            int kidCounter = 0;
            int totalTickets = 0;

            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }

                int freePlace = 0;
                freePlace = int.Parse(Console.ReadLine());
                int currentTickets = 0;
                for (int i = 0; i < freePlace; i++)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentsCounter++;
                    }
                    else if (ticketType == "standard")
                    {
                        standartCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCounter++;
                    }

                    totalTickets++;
                    currentTickets++;
                }

                Console.WriteLine($"{movieName} - {((currentTickets * 1.00 / freePlace * 1.00) * 100):f2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentsCounter * 1.00 / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standartCounter * 1.00 / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidCounter * 1.00 / totalTickets * 100:f2}% kids tickets.");
        }
    }
}