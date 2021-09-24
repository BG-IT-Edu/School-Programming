using System;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var bigNumber = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());

            var reversedResult = string.Empty;
            var residue = 0;

            for (var i = bigNumber.Length - 1; i >= 0; i--)
            {
                var currentResult = int.Parse(bigNumber[i].ToString()) * number + residue;

                if (currentResult >= 10)
                {
                    residue = currentResult / 10;
                    currentResult %= 10;
                }
                else
                {
                    residue = 0;
                }
                reversedResult += currentResult;
            }

            if (residue != 0)
            {
                reversedResult += residue;
            }

            var result = string.Empty;
            var isZero = true;

            for (var i = reversedResult.Length - 1; i >= 0; i--)
            {
                if (reversedResult[i] == '0' && isZero)
                {
                    continue;
                }

                isZero = false;

                if (!isZero)
                {
                    result += reversedResult[i];
                }
            }

            if (result == string.Empty)
            {
                result += 0;
            }

            Console.WriteLine(result);
        }
    }
}
