using System;

namespace _35.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBadGrades = int.Parse(Console.ReadLine());

            int badGradesCounter = 0;
            int problemsNumber = 0;
            string lastProblem = " ";
            double sumGrades = 0;

            while (true)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {sumGrades / problemsNumber:f2}");
                    Console.WriteLine($"Number of problems: {problemsNumber}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4.00)
                {
                    badGradesCounter++;
                }

                if (badGradesCounter == numberOfBadGrades)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    break;
                }

                sumGrades += grade;
                problemsNumber++;

                lastProblem = taskName;
            }
        }
    }
}