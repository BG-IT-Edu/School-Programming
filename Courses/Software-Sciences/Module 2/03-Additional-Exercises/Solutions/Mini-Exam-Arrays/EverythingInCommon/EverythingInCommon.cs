using System;
using System.Linq;

namespace EverythingInCommon
{
    class EverythingInCommon
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;
            var areEqual = false;

            for (var i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical.\nFound difference at {i} index");
                    break;
                }

                sum += firstArr[i];

                if (i == firstArr.Length - 1 && i == secondArr.Length - 1)
                {
                    areEqual = true;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical.\nSum: {sum}");
            }
        }
    }
}
