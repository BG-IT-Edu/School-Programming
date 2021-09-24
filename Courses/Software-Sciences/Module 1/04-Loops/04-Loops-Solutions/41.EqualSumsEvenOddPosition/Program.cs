using System;

namespace _41.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                string currNum = i.ToString();
                for (int j = 0; j < currNum.Length; j++)
                {
                    int currentNumber = int.Parse(currNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += currentNumber;
                    }
                    else
                    {
                        oddSum += currentNumber;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}