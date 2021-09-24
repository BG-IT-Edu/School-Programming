using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var numbers in phoneNumbers)
            {
                var currentNumber = numbers.Length == 10
                    ? smartphone.Call(numbers)
                    : stationaryPhone.Call(numbers);

                Console.WriteLine(currentNumber);
            }

            foreach (var site in sites)
            {
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
