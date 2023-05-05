using System;

namespace _28.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeByPerson = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double gradeScholarship = 0;

            if (grade > 4.50 && incomeByPerson < minimalSalary)
            {
                socialScholarship = minimalSalary * 0.35;

            }

            if (grade >= 5.50)
            {
                gradeScholarship = grade * 25;

            }

            if (socialScholarship != 0 && gradeScholarship != 0)
            {
                if (socialScholarship > gradeScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else if (gradeScholarship > socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
                }
                else if (socialScholarship == gradeScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
                }
            }
            else if (socialScholarship == 0 && gradeScholarship != 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
            }
            else if (socialScholarship != 0 && gradeScholarship == 0)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}