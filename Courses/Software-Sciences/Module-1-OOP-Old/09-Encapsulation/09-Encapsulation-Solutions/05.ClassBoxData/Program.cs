using System;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box calculateBoxParameters = new Box(length, width, height);
                Console.WriteLine(calculateBoxParameters);

            }
            catch (Exception test)
            {

                Console.WriteLine(test.Message);
            }
        }
    }
}
