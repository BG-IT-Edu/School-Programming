using System;

namespace ProgramLoyalCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] customerInfo = Console.ReadLine().Split(", ");
            int customerId = int.Parse(customerInfo[0]);
            string customerName = customerInfo[1];
            int customerAge = int.Parse(customerInfo[2]);
            string customerEmail = customerInfo[3];

            Customer customer = new Customer(customerId, customerName, customerAge, customerEmail);

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split();
                if (commands[0] == "Bonus")
                {
                    int points = int.Parse(commands[2]);
                    customer.AddBonusPoints(points);
                }
                else
                {
                    int points = int.Parse(commands[1]);
                    customer.ExchangePoints(points);
                }

                input = Console.ReadLine();
            }

        }
    }
}
