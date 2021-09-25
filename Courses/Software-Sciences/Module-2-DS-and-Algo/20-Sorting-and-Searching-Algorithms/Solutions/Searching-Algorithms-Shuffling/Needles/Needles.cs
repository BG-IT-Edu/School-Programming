using System;
using System.Collections.Generic;
using System.Linq;

public class Needles
{
    public static void Main()
    {
        int[] cn = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] needles = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int prev = numbers[cn[0] - 1];
        for (int i = cn[0] - 1; i >= 0; i--)
        {
            if (numbers[i] == 0)
            {
                numbers[i] = prev;
            }

            prev = numbers[i];
        }

        var result = new List<int>();
        for (int i = 0; i < cn[1]; i++)
        {
            bool isIn = false;
            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] >= needles[i])
                {
                    result.Add(j);
                    isIn = true;
                    break;
                }
            }

            if (!isIn)
            {
                int index = numbers.Count - 1;
                while (index > 0 && numbers[index] == 0)
                {
                    index--;
                }
                if (numbers[index] == 0)
                {
                    index--;
                }
                result.Add(index + 1);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}