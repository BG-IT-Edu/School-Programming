using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramLoyalCustomer
{
    public class Customer
    {
        private int customerId;
        private string name;
        private int age;
        private string email;
        private int bonusPoints;

        public Customer(int customerId, string name, int age, string email)
        {
            this.CustomerId = customerId;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.BonusPoints = 10;
        }
        public int BonusPoints
        {
            get { return bonusPoints; }
            set { bonusPoints = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public void AddBonusPoints(int points)
        {
            this.BonusPoints += points;
            Console.WriteLine($"You have {this.BonusPoints} bonus points.");
        }
        public void ExchangePoints(int points)
        {
            if (this.BonusPoints < points)
            {
                Console.WriteLine($"You do not have enough bonus points.");
            }
            else
            {
                this.BonusPoints -= points;
                Console.WriteLine($"You have {this.BonusPoints} points left.");
            }
        }

    }
}
