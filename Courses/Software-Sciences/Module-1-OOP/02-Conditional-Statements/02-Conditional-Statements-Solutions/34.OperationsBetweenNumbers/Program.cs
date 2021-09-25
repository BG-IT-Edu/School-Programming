using System;

namespace _34.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            char numbersOperator = char.Parse(Console.ReadLine());

            double result = 0;

            if (secondNumber == 0)
            {
                Console.WriteLine($"Cannot divide {firstNumber} by zero");
            }
            else if (numbersOperator == '+' || numbersOperator == '-' || numbersOperator == '*')
            {
                if (numbersOperator == '+')
                {
                    result = firstNumber + secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result} - odd");
                    }
                }
                else if (numbersOperator == '-')
                {
                    result = firstNumber - secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result} - odd");
                    }
                }
                else if (numbersOperator == '*')
                {
                    result = firstNumber * secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result} - odd");
                    }
                }
            }
            else if (numbersOperator == '/')
            {
                result = firstNumber * 1.00 / secondNumber * 1.00;

                Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result:f2}");
            }
            else if (numbersOperator == '%')
            {
                result = firstNumber % secondNumber;
                Console.WriteLine($"{firstNumber} {numbersOperator} {secondNumber} = {result}");
            }
        }
    }
}