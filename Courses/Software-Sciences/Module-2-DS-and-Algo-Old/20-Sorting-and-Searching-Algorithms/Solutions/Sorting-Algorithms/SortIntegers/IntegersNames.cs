using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class IntegersNames
{
    private static readonly string[] IntegerNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    public static void Main()
    {
        var nums = Console.ReadLine().Split(", ").ToArray();
        var numsToText = new Dictionary<string, string>();

        foreach (var num in nums)
        {
            StringBuilder numToText = new StringBuilder();
            Num2Text(num, numToText);
            numsToText.Add(num, numToText.ToString());
        }

        numsToText = numsToText.OrderBy(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
        Console.WriteLine(string.Join(", ", numsToText.Keys));
    }

    private static void Num2Text(string num, StringBuilder numToText)
    {
        foreach (var digit in num)
        {
            numToText.Append(IntegerNames[digit - '0']);
        }
    }
}
