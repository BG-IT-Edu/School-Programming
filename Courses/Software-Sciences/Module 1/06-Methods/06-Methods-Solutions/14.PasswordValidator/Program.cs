using System;

namespace _14.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string lengthResult = CheckLength(password);

            string characterResult = CheckContent(password);

            string digitResult = CheckDigits(password);

            if (lengthResult == "Password is valid" && characterResult == "Password is valid" && digitResult == "Password is valid")
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (lengthResult != "Password is valid")
                {
                    Console.WriteLine(lengthResult);
                }

                if (characterResult != "Password is valid")
                {
                    Console.WriteLine(characterResult);
                }

                if (digitResult != "Password is valid")
                {
                    Console.WriteLine(digitResult);
                }
            }
        }

        static string CheckLength(string password)
        {
            string result = "";

            if (password.Length >= 6 && password.Length <= 10)
            {
                result = "Password is valid";
            }
            else
            {
                result = "Password must be between 6 and 10 characters";
            }

            return result;
        }

        static string CheckContent(string password)
        {
            string result = "";
            bool flag = false;

            foreach (var character in password)
            {
                if ((character >= '0' && character <= '9') || (character >= 'A' && character <= 'Z') || (character >= 'a' && character <= 'z'))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            result = flag == true ? "Password is valid" : "Password must consist only of letters and digits";

            return result;
        }

        static string CheckDigits(string password)
        {
            string result = "";

            int counter = 0;

            foreach (var character in password)
            {
                if (character >= '0' && character <= '9')
                {
                    counter++;
                }
            }

            result = counter >= 2 ? "Password is valid" : "Password must have at least 2 digits";

            return result;
        }
    }
}