using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string paternName = @"[\W\d]";
            string paternDistence = @"[\W\D]";
            Regex nameReg = new Regex(paternName);
            Regex distenceReg = new Regex(paternDistence);
            string input = Console.ReadLine();
            Dictionary<string, int> results = new Dictionary<string, int>();
            while (input != "end of race")
            {

                string name = nameReg.Replace(input, "");
                string number = distenceReg.Replace(input, "");
                 
                int sum = 0;
                foreach (var digit in number)
                {
                    int digitN = int.Parse(digit.ToString());
                    sum += digitN;
                }
                if (participants.Contains(name))
                {
                    if (results.ContainsKey(name))
                    {
                        results[name] += sum;
                    }
                    else
                    {
                        results.Add(name, sum);
                    }
                }
               
                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var people in results.OrderByDescending(x=>x.Value))
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {people.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {people.Key}");

                }
                else if(count == 3)
                {
                    Console.WriteLine($"3rd place: {people.Key}");
                }
                else
                {
                    break;
                }
                count++;
            }
        }
    }
}
