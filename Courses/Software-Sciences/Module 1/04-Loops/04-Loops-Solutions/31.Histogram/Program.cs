using System;

namespace _31.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            double lessThan200Percent = 0;
            double from200to399Percent = 0;
            double from400to599Percent = 0;
            double from600to799Percent = 0;
            double above800Percent = 0;

            for (int i = 1; i <= counter; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    lessThan200Percent++;
                }
                else if (numbers >= 200 && numbers <= 399)
                {
                    from200to399Percent++;
                }
                else if (numbers >= 400 && numbers <= 599)
                {
                    from400to599Percent++;
                }
                else if (numbers >= 600 && numbers <= 799)
                {
                    from600to799Percent++;
                }
                else if (numbers >= 800)
                {
                    above800Percent++;
                }
            }

            Console.WriteLine($"{(lessThan200Percent / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(from200to399Percent / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(from400to599Percent / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(from600to799Percent / counter * 1.00) * 100:f2}%");
            Console.WriteLine($"{(above800Percent / counter * 1.00) * 100:f2}%");
        }
    }
}