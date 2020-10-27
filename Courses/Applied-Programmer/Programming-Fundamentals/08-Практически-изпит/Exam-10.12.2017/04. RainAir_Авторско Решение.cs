namespace _04._RainAir
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //A simple dictionary which will store our customers and their flights
            Dictionary<string, List<int>> flightsByCustomerName = new Dictionary<string, List<int>>();
            
            //A variable for the input
            string inputLine = string.Empty;

            //A simple while loop which reads until the end command is entered
            while ((inputLine = Console.ReadLine()) != "I believe I can fly!")
            {
                //We split the parameters
                string[] inputParameters = inputLine.Split(new []{' ', '='}, StringSplitOptions.RemoveEmptyEntries);

                //If the first is a letter, and the second is a number
                //Example: Pesho 1234
                //Then its a customer and his flights
                if (char.IsLetter(inputParameters[0][0]) && char.IsNumber(inputParameters[1][0]))
                {
                    //We extract the customer name
                    string customerName = inputParameters[0];
                    
                    //If the customerName does not exist in the dictionary, we initialize it
                    if (!flightsByCustomerName.ContainsKey(customerName))
                    {
                        flightsByCustomerName[customerName] = new List<int>();
                    }

                    //We add all flights to the customer
                    flightsByCustomerName[customerName].AddRange(inputParameters.Skip(1).Select(int.Parse));
                }
                //If the first is a letter, and the second is also a letter
                //Then its a name and a name
                //Example: Pesho = Gosho
                //Which means we must copy the second customer's flights to the first one
                else
                {
                    //We extract the 2 names
                    string originCustomerName = inputParameters[0];
                    string targetCustomerName = inputParameters[1];

                    //And we set the first customer's flight to the second
                    //We initialize a new List, because if we just say first = second
                    //The Lists will copy with reference
                    //And that might break
                    flightsByCustomerName[originCustomerName] = new List<int>(flightsByCustomerName[targetCustomerName]);
                }
            }

            //The ordering
            Dictionary<string, List<int>> sortedCustomers = 
                flightsByCustomerName
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            //The printing
            foreach (var customer in sortedCustomers)
            {
                //We also order the flights in ascending order
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(y => y))}");
            }
        }
    }
}
