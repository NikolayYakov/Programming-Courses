using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
            string text = string.Empty;
            int result = 0;
            for(int i = 0; i < numbers.Count / 2; i++)
            {
                result = numbers[i] + numbers[numbers.Count - 1 - i];
                text += result + " ";
                result = 0;
            }
            if (numbers.Count % 2 != 0)
            {
                text += numbers[numbers.Count / 2];
            }
            
            Console.WriteLine(text);
        }
    }
}
