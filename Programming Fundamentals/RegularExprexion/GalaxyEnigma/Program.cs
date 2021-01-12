using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GalaxyEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[starSTAR]";
            Regex dicript = new Regex(pattern);
            int countMessag = int.Parse(Console.ReadLine());
            string allMessages = string.Empty;
            for(int i = 0; i < countMessag; i++)
            {
                string text = Console.ReadLine();
                var matches = dicript.Matches(text);
                int count = matches.Count;
                char[] textChars = text.ToCharArray();
                for(int j = 0; j < textChars.Length; j++)
                {
                    int digit = textChars[j];
                    digit -= count;
                    textChars[j] = (char)digit;
                   
                }
                text = new string(textChars);
                allMessages += text + " ";
            }
            string patternMatch = @"@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(A|D)![^@\-!:>]*->(\d+)";
            Regex fillter = new Regex(patternMatch);
            int destroyed = 0;
            int attacked = 0;
            var matchesFinal = fillter.Matches(allMessages);
            List<string> attackedPlanets = new List<string>();
            List<string> distructedPlanets = new List<string>();

            foreach (Match match in matchesFinal)
            {
                string gruop = match.Groups[3].ToString();
                if (gruop == "A")
                {
                    attackedPlanets.Add(match.Groups[1].ToString());
                }
                else
                {
                    distructedPlanets.Add(match.Groups[1].ToString());
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {distructedPlanets.Count}");
            foreach (var item in distructedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");

            }
        }
    }
}
