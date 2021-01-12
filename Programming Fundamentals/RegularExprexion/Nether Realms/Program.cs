using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string letterPatern = @"[A-Za-z]";
            Dictionary<string, List<double>> demon = new Dictionary<string, List<double>>();
            Regex reg = new Regex(letterPatern);
            for(int i = 0; i < demons.Length; i++)
            {
                double health = 0.0;
                double power = 0.0;
                var matches = reg.Matches(demons[i]);
                string letters = string.Empty;
                foreach (Match item in matches)
                {
                    letters += item.ToString();
                }
                 
                char[] letter = letters.ToCharArray();
              
                for(int j = 0; j < letter.Length; j++)
                {
                    health += letter[j];
                }
                string numbers = Regex.Replace(demons[i], letterPatern, "");
                char[] digits = numbers.
                double multiCount = 0;
                double diviCount = 0;
                List<double> demage = new List<double>();
                for (int j = 0; j < digits.Length; j++)
                {
                    
                    
                   
                }

                if (diviCount != 0)
                {
                    power /= 2 * diviCount;
                }
                if (multiCount != 0)
                {
                    multiCount *= 2;
                    power *= multiCount;
                }
                demon.Add(demons[i], new List<double>());
                demon[demons[i]].Add(health);
                demon[demons[i]].Add(power);


            }
            foreach (var item in demon.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[1]:f0} health, {item.Value[2]:f2} damage");
            }

        }
    }
}
