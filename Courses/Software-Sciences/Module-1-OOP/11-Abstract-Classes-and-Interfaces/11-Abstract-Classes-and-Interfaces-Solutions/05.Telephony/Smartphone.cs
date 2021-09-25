using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {

        public string Call(string number)
        {
            if (number.Any(x => char.IsLetter(x)))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }
    }
}
