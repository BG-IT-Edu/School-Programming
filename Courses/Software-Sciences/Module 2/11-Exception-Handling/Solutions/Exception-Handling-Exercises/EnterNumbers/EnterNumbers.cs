using System;
using System.Collections.Generic;
using System.Linq;

class EnterNumbers
{
    static void Main()
    {
        var start = 1;
        var end = 100;

        var numbers = new List<int>();

        while (numbers.Count < 10)
        {
            start = ReadNumber(start, end);

            if (start > 1)
            {
                numbers.Add(start);
            }
        }
        
        Console.WriteLine(string.Join(", ", numbers));
    }
	
    static int ReadNumber(int start, int end)
    {
        try
        {
            var number = int.Parse(Console.ReadLine());
            
            if (number <= start || number >= end)
            {
                throw new Exception($"Your number is not in range {start} - {end}!");
            }

            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return 1;
    }
}