using System;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([+359]{4})([\s-])[2]\2([0-9]{3})\2([0-9]{4}\b)";
            string phone = Console.ReadLine();
            var matches = Regex.Matches(phone, pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
