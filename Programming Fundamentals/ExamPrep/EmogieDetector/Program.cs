using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmogieDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digitPatern = @"[\D]";
            Regex digitsReg = new Regex(digitPatern);
            string digits = digitsReg.Replace(text, "");
            BigInteger coolnes = new BigInteger();
            coolnes = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                int number = int.Parse(digits[i].ToString());
                coolnes *= number;
            }
            string pattern = @"([**]{2}|[::]{2})([A-Z][a-z]{2,})\1";
            Regex reg = new Regex(pattern);
            var matches = reg.Matches(text);
            List<string> emogies = new List<string>();
            int count = 0;
            foreach (Match match in matches)
            {
                count++;
                int value = 0;
                string emogi = match.Groups[2].ToString();
                for(int i = 0; i < emogi.Length; i++)
                {
                    value += emogi[i];
                }
                if (value >= coolnes)
                {
                    string fullText = match.ToString();
                    emogies.Add(fullText);
                }

            }
            Console.WriteLine($"Cool threshold: {coolnes}");
            Console.WriteLine($"{count} emojis found in the text. The cool ones are:");
            foreach (var item in emogies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
