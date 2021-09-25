using System;
using System.Text;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;
            double millilitresBeverage = 0;
            double gramsFood = 0;
            double calories = 0;

            while (input != "End")
            {
                string[] orderInput = input.Split();

                //Coffee - name, coffeine
                //Tea - name, price, millilitres
                if (orderInput[0] == "Coffee")
                {
                    string name = orderInput[1];
                    double caffeine = double.Parse(orderInput[2]);
                    Coffee coffee = new Coffee(name, caffeine);
                    sum += coffee.Price;
                    millilitresBeverage = coffee.Milliliters;
                }
                else if (orderInput[0] == "Tea")
                {
                    string name = orderInput[1];
                    decimal price = decimal.Parse(orderInput[2]);
                    double milliliters = double.Parse(orderInput[3]);
                    Tea tea = new Tea(name, price, milliliters);
                    sum += tea.Price;
                    millilitresBeverage = tea.Milliliters;
                }

                //Fish - name, price
                //Soup - name, price, grams
                //Cake - name
                else if (orderInput[0] == "Fish")
                {
                    string name = orderInput[1];
                    decimal price = decimal.Parse(orderInput[2]);
                    Fish fish = new Fish(name, price);
                    gramsFood += fish.Grams;
                    sum += fish.Price;
                }
                else if (orderInput[0] == "Soup")
                {
                    string name = orderInput[1];
                    decimal price = decimal.Parse(orderInput[2]);
                    double gramsSoup = double.Parse(orderInput[3]);
                    Soup soup = new Soup(name, price, gramsSoup);
                    sum += soup.Price;
                    gramsFood += soup.Grams;
                }

                else if (orderInput[0] == "Cake")
                {
                    string name = orderInput[1];

                    Cake cake = new Cake(name);
                    sum += cake.Price;
                    gramsFood += cake.Grams;
                    calories += cake.Calories;
                }

                input = Console.ReadLine();
            }

            if (calories == 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Your order contains:");
                sb.AppendLine($"  Quantity of liquids: {millilitresBeverage}");
                sb.AppendLine($"  Grams of food {gramsFood}");
                sb.AppendLine($"  Final amount {sum}");
                Console.WriteLine(sb.ToString());
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Your order contains:");
                sb.AppendLine($"  Quantity of liquids: {millilitresBeverage}");
                sb.AppendLine($"  Grams of food {gramsFood}");
                sb.AppendLine($"  Calories {calories}");
                sb.AppendLine($"  Final amount {sum}");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}