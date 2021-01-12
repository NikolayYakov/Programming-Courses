using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^%$|.]*<(\w+)>[^%$|.]*\|([0-9]+)\|[^%$|.\d]*([0-9]+[\.]?[0-9]*)\$";
            Regex reg = new Regex(pattern);
            string input = Console.ReadLine();
            string all = string.Empty;
            while(input!= "end of shift")
            {
                all += input + " ";
                input = Console.ReadLine();
            }
            var matches = reg.Matches(all);
            double totalSum = 0;
            foreach (Match match in matches )
            {
                double price = double.Parse(match.Groups[4].ToString());
                int count = int.Parse(match.Groups[3].ToString());
                double sum = price * count;
                Console.WriteLine($"{match.Groups[1]}: {match.Groups[2]} - {sum:f2}");
                totalSum += sum;
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
