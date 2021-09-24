using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSpaResort
{
    public class Customer : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
