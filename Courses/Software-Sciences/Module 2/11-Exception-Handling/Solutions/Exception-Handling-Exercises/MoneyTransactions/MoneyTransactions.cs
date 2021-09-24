using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyTransactions
{
    class MoneyTransactions
    {
        static void Main(string[] args)
        {
            var accountsArray = Console.ReadLine().Split(',').ToArray();
            var accounts = new Dictionary<int, double>();

            foreach (var accountData in accountsArray)
            {
                var couple = accountData.Split('-').ToArray();
                accounts.Add(int.Parse(couple[0]), double.Parse(couple[1]));
            }

            while (true)
            {
                var inputTokens = Console.ReadLine().Split(' ');
                if (inputTokens[0] == "End")
                {
                    break;
                }

                var command = inputTokens[0];
                var account = int.Parse(inputTokens[1]);
                var sum = double.Parse(inputTokens[2]);

                try
                {
                    if (command != "Deposit" && command != "Withdraw") throw new Exception("Invalid command!");
                    if (!accounts.ContainsKey(account)) throw new Exception("Invalid account!");
                    if (command == "Withdraw" && sum > accounts[account]) throw new Exception("Insufficient balance!");

                    if (command == "Deposit")
                    {
                        accounts[account] += sum;
                    }
                    else
                    {
                        accounts[account] -= sum;
                    }

                    Console.WriteLine($"Account {account} has new balance: {accounts[account]:F2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
    }
}
