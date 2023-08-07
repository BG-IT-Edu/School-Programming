using System;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            var validPasswords = new List<string>();

            foreach (var currentPassword in input)
            {
                var validLength = false;
                var validSymbols = true;

                if (currentPassword.Length >= 3 && currentPassword.Length <= 16)
                {
                    validLength = true;
                }

                foreach (var symbol in currentPassword)
                {
                    if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                    {
                        validSymbols = false;
                        break;
                    }
                }

                if (validSymbols && validLength)
                {
                    validPasswords.Add(currentPassword);
                }
            }

            foreach (var password in validPasswords)
            {
                Console.WriteLine(password);
            }
        }
    }
}
