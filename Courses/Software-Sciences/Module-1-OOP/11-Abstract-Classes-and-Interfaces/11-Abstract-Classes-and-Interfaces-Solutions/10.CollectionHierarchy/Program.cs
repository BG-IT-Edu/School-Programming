using System;
using System.Collections.Generic;

namespace CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdd addCollection = new AddCollection();
            IRemove addRemoveCollection = new AddRemoveCollection();
            IRemove myList = new MyList();

            Queue<IRemove> queue = new Queue<IRemove>();
            queue.Enqueue(addRemoveCollection);
            queue.Enqueue(myList);

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(addCollection.Add(input[i]) + " ");
            }
            Console.WriteLine();
            while (queue.Count != 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(queue.Peek().Add(input[i]) + " ");
                }
                Console.WriteLine();
                queue.Dequeue();
            }

            int n = int.Parse(Console.ReadLine());

            queue.Enqueue(addRemoveCollection);
            queue.Enqueue(myList);

            while (queue.Count != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(queue.Peek().Remove() + " ");
                }
                Console.WriteLine();
                queue.Dequeue();
            }
        }
    }
}
