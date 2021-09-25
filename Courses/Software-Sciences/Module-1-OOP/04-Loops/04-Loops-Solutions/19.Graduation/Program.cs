using System;

namespace _19.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int gradeCounter = 0;
            int excludeCounter = 0;
            double gradesSum = 0;
            while (gradeCounter < 12)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades >= 4.00)
                {
                    gradesSum += grades;
                }
                else if (grades < 4.00)
                {
                    excludeCounter++;
                }

                if (excludeCounter > 1)
                {
                    break;
                }

                gradeCounter++;
            }

            if (gradeCounter == 12)
            {
                double averageGrade = gradesSum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {gradeCounter} grade");
            }
        }
    }
}