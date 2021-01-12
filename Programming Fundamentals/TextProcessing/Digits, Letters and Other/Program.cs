using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] symbols = text.ToCharArray();
            string digits = string.Empty;
            string letters = string.Empty;
            string symbol = string.Empty;
            for(int i = 0; i < symbols.Length; i++)
            {
                if (char.IsDigit(symbols[i]))
                {
                    digits += symbols[i];
                }
                else if (char.IsLetter(symbols[i]))
                {
                    letters += symbols[i];

                }
                else if (char.IsWhiteSpace(symbols[i]))
                {

                }
                else
                {
                    symbol += symbols[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbol);
        }
    }
}
