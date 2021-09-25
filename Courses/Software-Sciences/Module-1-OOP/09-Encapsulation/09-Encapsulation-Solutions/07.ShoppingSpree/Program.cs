using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            List<Product> productList = new List<Product>();

            var peopleInput = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

            var productInput = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

            try
            {
                foreach (var input in peopleInput)
                {
                    string[] arr = input
                        .Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    if (arr.Length < 2)
                    {
                        Console.WriteLine("Name cannot be empty");
                        return;
                    }

                    Person person = new Person(arr[0], decimal.Parse(arr[1]));

                    if (!peopleList.Contains(person))
                        peopleList.Add(person);
                }

                foreach (var input in productInput)
                {
                    string[] arr = input
                        .Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    if (arr.Length < 2)
                    {
                        Console.WriteLine("Name cannot be empty");
                        return;
                    }

                    Product product = new Product(arr[0], decimal.Parse(arr[1]));

                    if (!productList.Contains(product))
                        productList.Add(product);
                }

                string command = string.Empty;

                while ((command = Console.ReadLine()) != "END")
                {
                    var tokens = command
                        .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string nameOfPerson = tokens[0];
                    string nameOfProduct = tokens[1];

                    Person currentPerson = peopleList.First(p => p.Name == nameOfPerson);
                    Product currentProduct = productList.First(p => p.Name == nameOfProduct);

                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        currentPerson.Products.Add(currentProduct);

                        currentPerson.Money -= currentProduct.Cost;

                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }

                foreach (Person person in peopleList)
                {
                    if (person.Products.Count > 0)
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.ToList().Select(p => p.Name))}");
                    else
                        Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
