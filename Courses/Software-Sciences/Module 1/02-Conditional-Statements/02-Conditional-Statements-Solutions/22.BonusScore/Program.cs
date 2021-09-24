using System;

namespace _22.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = int.Parse(Console.ReadLine());

            double bonusPoints = 0;

            if (point <= 100)
            {
                bonusPoints = 5;
            }
            else if (point > 100 & point <= 1000)
            {
                bonusPoints = point * 0.2;
            }
            else if (point > 1000)
            {
                bonusPoints = point * 0.1;
            }

            if (point % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (point % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            Console.WriteLine($"{bonusPoints}");
            Console.WriteLine($"{bonusPoints + point}");
        }
    }
}