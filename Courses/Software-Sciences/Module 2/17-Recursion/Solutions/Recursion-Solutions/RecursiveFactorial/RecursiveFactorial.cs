using System;

class RecursiveFactorial
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        long facturial = Factorial(input);

        Console.WriteLine(facturial);


    }

    private static long Factorial(int index)
    {
        if (index == 0)
        {
            return 1;
        }

        long currentSum = index * Factorial(index - 1);

        return currentSum;
    }
}

