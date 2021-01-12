using System;
using System.Text.RegularExpressions;
namespace NameCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var reg = new Regex(pattern);
            string text = Console.ReadLine();
            var matches = reg.Matches(text);
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
