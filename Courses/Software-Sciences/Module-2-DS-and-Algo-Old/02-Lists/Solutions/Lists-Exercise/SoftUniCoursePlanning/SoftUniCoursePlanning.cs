using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandWords = command.Split(':').ToArray();

                if (commandWords[0] == "Add")
                {
                    string newLesson = commandWords[1];
                    bool isInTheList = false;

                    foreach (var course in courses)
                    {
                        if (course == newLesson)
                        {
                            isInTheList = true;
                            break;
                        }
                    }

                    if (!isInTheList)
                    {
                        courses.Add(newLesson);
                    }
                }
                else if (commandWords[0] == "Insert")
                {
                    string newLesson = commandWords[1];
                    int index = int.Parse(commandWords[2]);
                    bool isInTheList = false;

                    for (int i = 0; i < courses.Count; i++)
                    {
                        if (courses[i] == newLesson)
                        {
                            isInTheList = true;
                            break;
                        }
                    }

                    if (!isInTheList)
                    {
                        courses.Insert(index, newLesson); 
                    }
                }
                else if (commandWords[0] == "Remove")
                {
                    string newLesson = commandWords[1];
                    string newExercise = newLesson + "-Exercise";
                    bool isInTheList = false;
                    bool exerciseInTheList = false;

                    for (int i = 0; i < courses.Count; i++)
                    {
                        if (courses[i] == newLesson)
                        {
                            isInTheList = true;
                            break;
                        }
                    }

                    foreach (var course in courses)
                    {
                        if (course == newExercise)
                        {
                            exerciseInTheList = true;
                            break;
                        }
                    }

                    if (isInTheList)
                    {
                        courses.Remove(newLesson);

                        if (exerciseInTheList)
                        {
                            courses.Remove(newExercise);
                        }
                    }
                }
                else if (commandWords[0] == "Swap")
                {
                    string firstLesson = commandWords[1];
                    string secondLesson = commandWords[2];
                    string firstExercise = firstLesson + "-Exercise";
                    string secondExercise = secondLesson + "-Exercise";
                    bool firstIsInTheList = false;
                    bool secondIsInTheList = false;
                    bool secondExerciseIsInTheList = false;
                    int firstIndex = 0;
                    int secondIndex = 0;

                    for (int i = 0; i < courses.Count; i++)
                    {
                        if (courses[i] == firstLesson)
                        {
                            firstIsInTheList = true;
                            firstIndex = i;
                            break;
                        }
                    }

                    foreach (var course in courses)
                    {
                        if (course == firstExercise)
                        {
                            firstIsInTheList = true;
                            break;
                        }
                    }

                    for (int i = 0; i < courses.Count; i++)
                    {
                        if (courses[i] == secondLesson)
                        {
                            secondIsInTheList = true;
                            secondIndex = i;
                            break;
                        }
                    }

                    foreach (var course in courses)
                    {
                        if (course == secondExercise)
                        {
                            secondExerciseIsInTheList = true;
                            break;
                        }
                    }

                    if (firstIsInTheList && secondIsInTheList)
                    {
                        string temp = courses[firstIndex];
                        courses[firstIndex] = courses[secondIndex];
                        courses[secondIndex] = temp;

                        if (secondExerciseIsInTheList)
                        {
                            courses.RemoveAt(secondIndex + 1);
                            courses.Insert(firstIndex + 1, secondExercise);
                        }
                    }
                }
                else if (commandWords[0] == "Exercise")
                {
                    string newLesson = commandWords[1];
                    string newExercise = newLesson + "-Exercise";
                    bool exerciseIsInTheList = false;
                    bool lessonIsInTheList = false;
                    int lessonIndex = 0;

                    for (int i = 0; i < courses.Count; i++)
                    {
                        if (courses[i] == newLesson)
                        {
                            lessonIsInTheList = true;
                            lessonIndex = i;
                            break;
                        }
                    }

                    foreach (var course in courses)
                    {
                        if (course == newExercise)
                        {
                            exerciseIsInTheList = true;
                            break;
                        }
                    }

                    if (!exerciseIsInTheList && !lessonIsInTheList)
                    {
                        courses.Add(newLesson);
                        courses.Add(newExercise);
                    }
                    else if (!exerciseIsInTheList && lessonIsInTheList)
                    {
                        courses.Insert(lessonIndex + 1, newExercise);
                    }
                }
                
                command = Console.ReadLine();
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
