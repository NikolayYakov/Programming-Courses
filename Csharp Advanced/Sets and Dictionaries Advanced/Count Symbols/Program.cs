using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (!characters.ContainsKey(input[i]))
                {
                    characters.Add(input[i], 0);
                }
                characters[input[i]]++;
            }
            foreach (var ch in characters.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
