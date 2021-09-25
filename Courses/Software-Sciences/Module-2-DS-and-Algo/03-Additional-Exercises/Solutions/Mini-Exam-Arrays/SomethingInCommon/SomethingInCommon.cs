using System;
using System.Linq;

namespace SomethingInCommon
{
    class SomethingInCommon
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split().ToArray();
            var secondArr = Console.ReadLine().Split().ToArray();

            foreach (var element1 in secondArr)
            {
                foreach (var element2 in firstArr)
                {
                    if (element1 == element2)
                    {
                        Console.Write(element1 + " ");
                    }
                }
            }
        }
    }
}
