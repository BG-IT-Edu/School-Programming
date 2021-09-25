using System;

namespace P07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var item1 = firstLine[0] + " " + firstLine[1];
            var item2 = firstLine[2];
            var item3 = "";
            for (int i = 3; i < firstLine.Length; i++)
            {
                item3 += firstLine[i] + " ";
            }
            item3 = item3.Trim().ToString();
            var firstResult = new Threeuple<string, string, string>(item1, item2, item3);
            Console.WriteLine(firstResult);
            var secondLine = Console.ReadLine().Split();
            item1 = secondLine[0];
            var intItem = int.Parse(secondLine[1]);
            var boolItem = false;
            if (secondLine[2] == "drunk")
            {
                boolItem = true;
            }
            var secondResult = new Threeuple<string, int, bool>(item1, intItem, boolItem);
            Console.WriteLine(secondResult);
            var thirdLine = Console.ReadLine().Split();
            item1 = thirdLine[0];
            var doubleItem = double.Parse(thirdLine[1]);
            item3 = thirdLine[2];
            var thirdResult = new Threeuple<string, double, string>(item1, doubleItem, item3);
            Console.WriteLine(thirdResult);
        }
    }
}
