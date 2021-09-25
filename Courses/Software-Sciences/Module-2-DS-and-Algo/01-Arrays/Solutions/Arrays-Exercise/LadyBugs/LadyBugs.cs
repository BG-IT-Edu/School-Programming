using System;
using System.Linq;

namespace LadyBugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] field = new int[length];
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                if (indexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            string[] command = Console.ReadLine().Split(' ');
            int ladybugIndex = 0;
            string direction = "";
            int flyLength = 0;

            while (command[0] != "end")
            {
                ladybugIndex = int.Parse(command[0]);
                direction = command[1];
                flyLength = int.Parse(command[2]);
                int newIndex = 0;

                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1 || field[ladybugIndex] == 0)
                {
                    command = Console.ReadLine().Split(' ');
                    continue;
                }

                if (flyLength == 0 && ladybugIndex >= 0 && ladybugIndex <= field.Length - 1)
                {
                    if (field[ladybugIndex] == 1)
                    {
                        field[ladybugIndex] = 0;
                    }
                }

                if (flyLength < 0)
                {
                    switch (direction)
                    {
                        case "left":
                            direction = "right";
                            flyLength = Math.Abs(flyLength);
                            break;
                        case "right":
                            direction = "left";
                            flyLength = Math.Abs(flyLength);
                            break;
                    }
                }

                switch (direction)
                {

                    case "right":
                        newIndex = ladybugIndex + flyLength;
                        field[ladybugIndex] = 0;
                        if (newIndex > field.Length - 1)
                        {
                            field[ladybugIndex] = 0;
                            break;
                        }
                        else
                        {
                            for (int i = newIndex; i < field.Length; i += flyLength)
                            {
                                if (field[i] == 0)
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                        break;
                    case "left":
                        newIndex = ladybugIndex - flyLength; field[ladybugIndex] = 0;
                        if (newIndex < 0)
                        {
                            field[ladybugIndex] = 0;
                            break;
                        }
                        else
                        {
                            for (int i = newIndex; i >= 0; i -= flyLength)
                            {
                                if (field[i] == 0)
                                {
                                    field[i] = 1;
                                    break;
                                }
                            }
                        }
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"{String.Join(" ", field)}");
        }
    }
}
