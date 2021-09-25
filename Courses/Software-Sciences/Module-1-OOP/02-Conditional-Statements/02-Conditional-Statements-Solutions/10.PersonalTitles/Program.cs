using System;

namespace _10.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "m":
                    if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Mr.");
                    }

                    break;
                case "f":
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }

                    break;
            }
        }
    }
}