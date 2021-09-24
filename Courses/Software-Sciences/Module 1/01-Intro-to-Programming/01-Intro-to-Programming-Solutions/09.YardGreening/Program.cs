using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double withoutDiscount = size * 7.61;
            double discount = withoutDiscount * 0.18;
            Console.WriteLine($"The final price is: {withoutDiscount - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}