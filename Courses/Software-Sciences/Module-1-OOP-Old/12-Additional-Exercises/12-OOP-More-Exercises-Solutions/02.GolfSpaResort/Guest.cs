using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSpaResort
{
    public class Guest : Customer
    {
        public Guest(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public string NewGuest()
        {
            return $"Mr/Ms/Mrs {this.FirstName} {this.LastName} registers as a guest.";
        }
    }
}
