using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private string accountNumber;
        private string ownerName;
        private decimal accountBalance;

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public BankAccount(string accountNumber, string ownerName, decimal accountBalance)
        {
            this.AccountNumber = accountNumber;
            this.OwnerName = ownerName;
            this.AccountBalance = accountBalance;
        }
        public void MakeDeposit(decimal amount)
        {
            this.AccountBalance += amount;
            Console.WriteLine($"Account balance: {this.AccountBalance}");
        }
        public void MakeWithdrawal(decimal amount)
        {
            if (this.AccountBalance - amount < 0)
            {
                Console.WriteLine("Non-Sufficient Funds");
            }
            else
            {
                this.AccountBalance -= amount;
                Console.WriteLine($"Withdrawn funds: {amount}. Funds available on the account: {this.AccountBalance}");
            }

        }
    }
}
