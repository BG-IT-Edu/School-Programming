using System;

namespace SumOfIntegers
{
    class SumOfIntegers
    {
        static void Main(string[] args)
        {
            var inputElements = Console.ReadLine().Split(' ');
            var sum = 0;

            foreach (var element in inputElements)
            {
                try
                {
                    sum += int.Parse(element);
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
