using System;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }

            Console.WriteLine(String.Join(' ', wagons));
            Console.WriteLine(sum);
        }
    }
}
