using System;
using System.Collections.Generic;

namespace Shopping_Center
{
    public class StartUp
    {
        private static readonly ProductList ProductList = new ProductList();

        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var command = Console.ReadLine();
                ProcessCommand(command);
            }
        }

        private static void ProcessCommand(string input)
        {
            input = input.Trim();

            var index = input.IndexOf(' ');
            var command = input.Substring(0, index);

            input = input.Substring(index + 1);

            var args = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string result;

            switch (command)
            {
                case "AddProduct":
                    result = AddProduct(args);
                    break;
                case "DeleteProducts":
                    result = DeleteProducts(args);
                    break;
                case "FindProductsByName":
                    result = FindProductsByName(args);
                    break;
                case "FindProductsByProducer":
                    result = FindProductsByProducer(args);
                    break;
                case "FindProductsByPriceRange":
                    result = FindProductsByPriceRange(args);
                    break;
                default:
                    result = "Invalid Command";
                    break;
            }

            Console.WriteLine(result);
        }

        private static string FindProductsByPriceRange(string[] args)
        {
            var from = decimal.Parse(args[0]);
            var to = decimal.Parse(args[1]);

            var products = ProductList.FindProductsByPriceRange(from, to);
            return ConcatenateProducts(products);
        }

        private static string FindProductsByProducer(string[] args)
        {
            var producer = args[0];

            var products = ProductList.FindProductsProducer(producer);
            return ConcatenateProducts(products);
        }

        private static string FindProductsByName(string[] args)
        {
            var name = args[0];

            var products = ProductList.FindProductsByName(name);
            return ConcatenateProducts(products);
        }

        private static string ConcatenateProducts(IEnumerable<Product> products)
        {
            var result = string.Join(Environment.NewLine, products);

            if (string.IsNullOrWhiteSpace(result))
            {
                result = $"No products found";
            }

            return result;
        }

        private static string DeleteProducts(string[] args)
        {
            int count;

            if (args.Length == 2)
            {
                var name = args[0];
                var producer = args[1];
                count = ProductList.DeleteByNameAndProducer(name, producer);
            }
            else
            {
                var producer = args[0];
                count = ProductList.DeleteByProducer(producer);
            }

            if (count > 0)
            {
                return $"{count} products deleted";
            }

            return $"No products found";
        }

        private static string AddProduct(string[] args)
        {
            var name = args[0];
            var price = decimal.Parse(args[1]);
            var producer = args[2];
            ProductList.AddProduct(name, price, producer);
            return $"Product added";
        }
    }
}
