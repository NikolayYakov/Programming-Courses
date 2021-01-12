using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            List<char> alpha = "1ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().ToList();
            double totalSum = 0.0;
            foreach (var item in numbers)
            {
                double curentSum = 0;
                string firstLetter = item[0].ToString();
                string lastLetter = item[item.Length-1].ToString();
                int firstIndex = alpha.IndexOf(char.Parse(firstLetter.ToUpper()));
                int secondIndex = alpha.IndexOf(char.Parse(lastLetter.ToUpper()));
                string digit = string.Empty;
                for (int i = 0; i < item.Length; i++)
                {
                   
                    if (char.IsDigit(item[i]))
                    {
                        digit += item[i];
                    }
                }
                int number = int.Parse(digit);
                curentSum += number;
                if (char.IsUpper(char.Parse(firstLetter)))
                {
                    curentSum /= firstIndex;
                }
                else
                {
                    curentSum *= firstIndex;
                }
                if (char.IsUpper(char.Parse(lastLetter)))
                {
                    curentSum -= secondIndex;
                }
                else
                {
                    curentSum += secondIndex;
                }
                totalSum += curentSum;

            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}

