using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool isLengthValid = IsPasswordLengthValid(inputPassword);
            bool isPassAlphaNumericValid = IsPasswordAlphaNumeric(inputPassword);
            bool isPassContainingTwoDigits = IsPasswordContainingAtLeastTwoDigits(inputPassword);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassAlphaNumericValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPassContainingTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid && isPassAlphaNumericValid && isPassContainingTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordContainingAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;

        }
    }
}
