using System;

namespace _33.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= openedTabs; i++)
            {
                string websiteName = Console.ReadLine();
                if (websiteName == "Facebook")
                {
                    salary -= 150;
                }
                else if (websiteName == "Instagram")
                {
                    salary -= 100;
                }
                else if (websiteName == "Reddit")
                {
                    salary -= 50;
                }

                if (salary == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}