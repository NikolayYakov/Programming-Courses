using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
           for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }
                                     
            string odd = string.Empty;
            Dictionary<string, int> collection = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (collection.ContainsKey(word))
                {
                    collection[word]++;
                }
                else
                {
                    collection.Add(word, 1);
                }
            }
            foreach ( var word in collection)
            {
                
                if (word.Value % 2 != 0)
                {
                    odd += word.Key + " ";
                }
            }
            Console.WriteLine(odd);
        }
    }
}
