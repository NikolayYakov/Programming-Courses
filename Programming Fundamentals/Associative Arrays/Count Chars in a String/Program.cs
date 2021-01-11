using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
             
            char[] chars = word.ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var symbol in chars)
            {
                if (symbol != ' ')
                {
                    if (dictionary.ContainsKey(symbol))
                    {
                        dictionary[symbol]++;
                    }
                    else
                    {
                        dictionary.Add(symbol, 1);
                    }
                }
            }
            foreach (var symbols in dictionary)
            {
                Console.WriteLine($"{symbols.Key} -> {symbols.Value}");
            }
        }
    }
}
