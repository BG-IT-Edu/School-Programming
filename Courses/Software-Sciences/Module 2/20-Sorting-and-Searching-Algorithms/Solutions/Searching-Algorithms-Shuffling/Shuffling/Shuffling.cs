using System;
using System.Linq;
class Shuffling
{
    static void Main()
    {
        var words = Console.ReadLine().Split(" ").ToArray();
        Shuffle(words);
        Console.WriteLine(string.Join(Environment.NewLine, words));
    }

    private static void Shuffle(string[] elements)
    {
        Random rnd = new Random();

        for (int i = 0; i < elements.Length; i++)
        {
            // Exchange array[i] with random element in array[i … n-1]
            int next = rnd.Next(1, elements.Length);

            string oldElement = elements[i];
            elements[i] = elements[next];
            elements[next] = oldElement;
        }
    }
}
