using System;
using System.Collections.Generic;
using System.Linq;

namespace _3LargestNumebrs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            List<int> maxList = new List<int>(3);
            for(int i = 0; i < 3; i++)
            {
                if (numbers.Count <= 0)
                {
                    break;
                }
                int max = numbers.Max();
                maxList.Add(max);
                numbers.Remove(max);

            }
            Console.WriteLine(string.Join(" ", maxList));
        }
    }
}
