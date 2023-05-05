using System;
using System.Linq;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaItems = Console.ReadLine().Split();
                string pizzaName = pizzaItems[1];

                string[] doughItems = Console.ReadLine().Split();

                string flour = doughItems[1];
                string backeType = doughItems[2];
                double weight = double.Parse(doughItems[3]);
                Dough dough = new Dough(flour, backeType, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string line = Console.ReadLine();

                while (line != "END")
                {
                    string[] toppingItems = line.Split();

                    string type = toppingItems[1];
                    double weigh = double.Parse(toppingItems[2]);
                    Topping topping = new Topping(type, weigh);

                    pizza.AddTopping(topping);

                    line = Console.ReadLine();
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
