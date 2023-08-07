using System;

namespace DigitsLettersAndOther
{
    class DigitsLettersAndOther
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var digits = string.Empty;
            var letters = string.Empty;
            var others = string.Empty;

            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    digits += item;
                }
                else if (char.IsLetter(item))
                {
                    letters += item;
                }
                else
                {
                    others += item;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
