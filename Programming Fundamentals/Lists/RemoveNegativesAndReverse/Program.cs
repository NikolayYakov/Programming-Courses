using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            List<int> positive = numbers.Where(n => n > 0)
                                 .Reverse()
                                 .ToList();
            if (positive.Count != 0)
            {
                Console.WriteLine(string.Join(" ", positive));
            }
            else
            {
                Console.WriteLine("empty");
            }
            

        }
    }
}
