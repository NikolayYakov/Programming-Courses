using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string word = command;
                char[] reverse = word.ToCharArray();
                Array.Reverse(reverse);
                string reversed = new string(reverse);
                words.Add(word, reversed);
                command = Console.ReadLine();
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} = {word.Value}");
            }
        }
    }
}
