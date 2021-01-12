using System;
using System.Text.RegularExpressions;

namespace Exersice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"([*]|[@])([A-Z][a-z]{2,})\1: \[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$";
            Regex reg = new Regex(patern);
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                if (reg.IsMatch(text))
                {
                    var matches= reg.Matches(text);
                    foreach (Match item in matches)
                    {
                        char firstCha = char.Parse(item.Groups[3].ToString());
                        char secondCha = char.Parse(item.Groups[4].ToString());
                        char thirdCha = char.Parse(item.Groups[5].ToString());
                        int firstSum = firstCha;
                        int secondSum = secondCha;
                        int thirdSum = thirdCha;

                        Console.WriteLine($"{item.Groups[2]}: {firstSum} {secondSum} {thirdSum}");
                    }

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
