using System;
using System.Linq;

namespace EqualSum
{
    class EqualSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            foreach (var item in array)
            {
                rightSum += item;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (leftSum == rightSum - array[i])
                {
                    Console.WriteLine(i);
                    break;
                }

                leftSum += array[i];
                rightSum -= array[i];

                if (i == array.Length - 1 && leftSum != rightSum - array[i])
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
