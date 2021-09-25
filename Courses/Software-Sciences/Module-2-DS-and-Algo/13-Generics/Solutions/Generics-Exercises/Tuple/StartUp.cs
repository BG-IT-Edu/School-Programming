using System;

namespace _07.Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split();
            var fullName = $"{firstLine[0]} {firstLine[1]}";
            var address = firstLine[2];
            var firstTuple = new Tuple<string, string>(fullName, address);

            var secondLine = Console.ReadLine().Split();
            var name = secondLine[0];
            var amountOfBeer = int.Parse(secondLine[1]);
            var secondTuple = new Tuple<string, int>(name, amountOfBeer);

            var thirdLine = Console.ReadLine().Split();
            var integer = int.Parse(thirdLine[0]);
            var @double = double.Parse(thirdLine[1]);
            var thirdTuple = new Tuple<int, double>(integer, @double);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
