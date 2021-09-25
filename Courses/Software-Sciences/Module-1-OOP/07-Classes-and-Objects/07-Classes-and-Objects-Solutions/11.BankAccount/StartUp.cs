using System;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] customerInfo = Console.ReadLine().Split();
            string accountNumber = customerInfo[0];
            string ownerName = customerInfo[1] + " " + customerInfo[2];
            decimal accountBalance = decimal.Parse(customerInfo[3]);

            BankAccount account = new BankAccount(accountNumber, ownerName, accountBalance);

            string commands = Console.ReadLine();
            while (commands != "End")
            {
                string[] commandsParameter = commands.Split();
                decimal amount = decimal.Parse(commandsParameter[1]);

                if (commandsParameter[0] == "Deposit")
                {
                    account.MakeDeposit(amount);
                }
                else
                {
                    account.MakeWithdrawal(amount);
                }

                commands = Console.ReadLine();
            }
        }
    }
}