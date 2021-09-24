using System;
using System.Linq;

namespace KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] sequence = new int[length];

            string command = Console.ReadLine();
            int[] bestSequence = new int[length];

            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int leftMostIndex = 0;
            int sequenceIndex = 0;
            int bestSubsequence = 0;

            while (command != "Clone them!")
            {
                sequence = command.Split(new[] { "!" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                sequenceIndex++;

                int leftIndex = sequence.Length - 1;
                int subsequence = 1;
                int sum = 0;

                for (int i = 0; i < sequence.Length; i++)
                {
                    sum += sequence[i];
                    if (i != sequence.Length - 1 && sequence[i] == sequence[i + 1] && sequence[i] == 1)
                    {
                        subsequence++;
                        if (leftIndex > i)
                        {
                            leftIndex = i;
                        }
                    }
                }

                if (subsequence > bestSubsequence 
                    || subsequence == bestSubsequence && leftIndex < leftMostIndex 
                    || subsequence == bestSubsequence && leftIndex == leftMostIndex && sum > bestSequenceSum)
                {
                    bestSubsequence = subsequence;
                    leftMostIndex = leftIndex;
                    bestSequenceIndex = sequenceIndex;
                    bestSequenceSum = sum;
                    bestSequence = sequence;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine($"{String.Join(" ", bestSequence)}");
        }
    }
}
