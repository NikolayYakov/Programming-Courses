using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for(int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }
            elements = elements.OrderBy(x => x).ToHashSet();
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
