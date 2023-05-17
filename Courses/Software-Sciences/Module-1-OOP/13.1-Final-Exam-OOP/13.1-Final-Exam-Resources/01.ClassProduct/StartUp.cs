using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IProduct product = new Product("Cake", 5.20m);

            Console.WriteLine($"Product name: {product.Name}");
            Console.WriteLine($"Product price: {product.Price}");

            decimal discountedPrice = product.GetPriceWithDiscount(10);
            Console.WriteLine($"Discounted price: {discountedPrice}");

            product.PrintInformation();
        }
    }
}
