using System;
using System.Linq;

namespace MaxSequenceОfEqualElements
{
    class MaxSequenceОfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequence = 1;
            int BestSequenceSize = 0;
            int BestSequenceNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currnetNUmber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    if (currnetNUmber == rightNumber)
                    {
                        sequence += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequence > BestSequenceSize)
                {
                    BestSequenceSize = sequence;
                    BestSequenceNumber = arr[i];
                }

                sequence = 1;
            }

            for (int k = 0; k < BestSequenceSize; k++)
            {
                Console.Write($"{BestSequenceNumber} ");
            }
        }
    }
}
