using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string pattern = @"[@][#]+([A-Z][A-Z0-9a-z]{4,}[A-Z])[@][#]+";
            string digitPatern = @"[\d]+";
            Regex reg = new Regex(pattern);
            Regex digReg = new Regex(digitPatern);
            for (int i = 0; i < count; i++)
            {
                string barcode = Console.ReadLine();
                bool isMatch = reg.IsMatch(barcode);
                if (isMatch == true)
                {
                    string digits = string.Empty;
                    var matches = digReg.Matches(barcode);
                    foreach (Match item in matches)
                    {
                        digits += item;
                    }
                    if (digits == "")
                    {
                        digits = "00";
                    }
                    Console.WriteLine($"Product group: {digits}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
