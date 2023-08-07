using MoreComplexDataStructures;
using System;

class Heap
{
    static void Main()
    {
        MaxHeap<string> heap = new MaxHeap<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            heap.Insert(name);
        }

        while (heap.Count > 0)
        {
            Console.WriteLine(heap.ExtractMax());
        }

    }
}
