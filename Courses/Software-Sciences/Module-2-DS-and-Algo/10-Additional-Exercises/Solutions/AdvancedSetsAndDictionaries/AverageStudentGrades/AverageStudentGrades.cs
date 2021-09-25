using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
            }

            foreach (var student in students)
            {
                double averageGrade = student.Value.Average();

                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {averageGrade:F2})");
            }
        }
    }
}
