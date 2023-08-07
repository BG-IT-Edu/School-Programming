using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\+359( |-)2\1\d{3}\1\d{4}\b");

            var inputNumbers = Console.ReadLine();

            var validNumbers = regex.Matches(inputNumbers);

            Console.WriteLine(string.Join(", ", validNumbers));
        }
    }
}