using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string final = string.Empty;
            string text = Console.ReadLine();
            string pattern = @">>([a-zA-Z]+)<<([0-9]+[.]?[0-9]*)!([0-9]+)";
            Regex reg = new Regex(pattern);
            while(text!= "Purchase")
            {
                final += text + " ";
                text = Console.ReadLine();
            }
            var matches = reg.Matches(final);
            double sum = 0.0;
            Console.WriteLine("Bought furniture:");
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[1]);
                string digit = item.Groups[2].ToString();
                string count = item.Groups[3].ToString();
                int countN = int.Parse(count);
                
                double number = double.Parse(digit);
                number *= countN;
                sum += number;
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
             
        }
    }
}
