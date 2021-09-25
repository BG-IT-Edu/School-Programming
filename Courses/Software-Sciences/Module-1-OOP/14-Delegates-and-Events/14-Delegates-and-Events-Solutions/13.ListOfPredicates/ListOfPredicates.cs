using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<int, int, bool> devide = (n, m) => n % m == 0;

            var divisibleNums = new List<int>();
            bool divisible = true;

            for (int n = 1; n <= num; n++)
            {
                divisible = true;

                for (int i = 0; i < nums.Count; i++)
                {

                    if (!devide(n, nums[i]))
                    {
                        divisible = false;
                        break;
                    }

                    else
                    {
                        continue;
                    }

                }

                if (divisible == true)
                {
                    divisibleNums.Add(n);
                }

            }

            Action<List<int>> print = n => Console.Write(String.Join(" ", n));
            print(divisibleNums);
        }
    }
}
