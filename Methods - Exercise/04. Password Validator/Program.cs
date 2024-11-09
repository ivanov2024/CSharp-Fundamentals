using System.Linq;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            Password_Validator(password);
        }

        static void Password_Validator(string password)
        {
            Characters_Length_Checker(password);
            Letters_And_DigitsChecker(password);
            DigitsChecker(password);

            if (Characters_Length_Checker(password) 
                && Letters_And_DigitsChecker(password) 
                && DigitsChecker(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!Characters_Length_Checker(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!Letters_And_DigitsChecker(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!DigitsChecker(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool Characters_Length_Checker(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Letters_And_DigitsChecker(string password)
        {
            foreach (var item in password)
            {
                if (item >= 65 && item <= 90 ||
                    item >= 97 && item <= 122 ||
                    item >= 48 && item <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static bool DigitsChecker(string password)
        {
            int digitCount = 0;

            foreach (var digit in password)
            {
                if (digit >= 48 && digit <= 57)
                {
                    digitCount++;
                }
            }

            if (digitCount < 2)
            {
                return false;
            }

            return true;
        }
    }
}