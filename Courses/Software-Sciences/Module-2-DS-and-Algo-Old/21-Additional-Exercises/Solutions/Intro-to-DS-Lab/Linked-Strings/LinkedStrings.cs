using System;
using System.Collections.Generic;

class LinkedStrings
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        string thirdWord = Console.ReadLine();
        string fourthWord = Console.ReadLine();
        list.AddFirst(firstWord);
        list.AddLast(secondWord);
        list.AddAfter(list.First, thirdWord);
        list.AddBefore(list.Last, fourthWord);

        Console.WriteLine(string.Join(", ", list));
    }
}