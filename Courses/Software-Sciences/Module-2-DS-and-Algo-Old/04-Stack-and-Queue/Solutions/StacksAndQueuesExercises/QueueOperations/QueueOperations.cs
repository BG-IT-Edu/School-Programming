using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueOperations
{
    class QueueOperations
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int countOfElements = input[0];
            int countToRemove = input[1];
            int wantedElement = input[2];

            int[] arrayOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //FillQueueWithNumbers
            Queue<int> elements = new Queue<int>();
            elements = FillWithElements(elements, arrayOfNumbers, countOfElements);

            //Delete elements
            elements = DeleteElements(elements, countToRemove);


            //Search element
            SearchingElement(elements, wantedElement);
        }
        public static Queue<int> FillWithElements(Queue<int> elements, int[] array, int countOfElements)
        {
            for (int i = 0; i < countOfElements; i++)
            {
                elements.Enqueue(array[i]);
            }

            return elements;
        }

        public static Queue<int> DeleteElements(Queue<int> elements, int countToRemove)
        {
            for (int i = 1; i <= countToRemove; i++)
            {
                if (elements.Count > 0)
                {
                    elements.Dequeue();
                }
            }

            return elements;
        }

        public static void SearchingElement(Queue<int> elements, int wantedElement)
        {
            if (elements.Count > 0)
            {
                if (elements.Contains(wantedElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(elements.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
