using System;

namespace _12.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int periodDeposit = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());

            // сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

            double sum = depositSum + periodDeposit * ((depositSum * (yearInterest / 100)) / 12);

            Console.WriteLine(sum);
        }
    }
}