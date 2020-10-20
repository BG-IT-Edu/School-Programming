using System;

namespace Transaction
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneyInUsd = double.Parse(Console.ReadLine());

            double bitcoinPriceInUsd = double.Parse(Console.ReadLine());

            int satoshiPerByte = int.Parse(Console.ReadLine());

            double bitcoinsAvailableToBuy = moneyInUsd / bitcoinPriceInUsd;

            double totalTransactionCostInBtc = bitcoinsAvailableToBuy * (satoshiPerByte * 1024) / 100000000;

            double bitcoinsBought = bitcoinsAvailableToBuy - totalTransactionCostInBtc;

            double usdSpentOnTaxes = totalTransactionCostInBtc * bitcoinPriceInUsd;

            double programmersCommission = bitcoinsBought * (10.0/100);

            double bitcoinsAfterExpenses = bitcoinsBought - programmersCommission;


            Console.WriteLine($"Total bitcoin after expenses: {bitcoinsAfterExpenses:F5} BTC");
            Console.WriteLine($"Tax payed: {usdSpentOnTaxes:F2} USD");
            Console.WriteLine($"Programmer`s payment: {programmersCommission:F5} BTC");
        }
    }
}
