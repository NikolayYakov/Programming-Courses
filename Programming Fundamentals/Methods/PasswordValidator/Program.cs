using System;
namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLong = PasswordLength(password);
            bool twoDigits = TwoDigits(password);
            bool noSpecialSymbols = NoSpecialSymbols(password);
            if (isLong == true&&twoDigits == true && noSpecialSymbols == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (isLong == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (noSpecialSymbols == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (twoDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool PasswordLength(string password)
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
        static bool TwoDigits(string password)
        {
            int digits = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c)==true)
                {
                    digits++;
                }
            }
            if (digits >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool NoSpecialSymbols(string password)
        {
            bool isTrue = false;
            foreach (char c in password)
            {
                if (char.IsLetterOrDigit(c)==true)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }

            }
            if (isTrue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
