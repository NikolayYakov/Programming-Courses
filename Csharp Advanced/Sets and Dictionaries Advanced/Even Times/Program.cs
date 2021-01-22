using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }
            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0 && num.Value != 0)
                {
                    Console.WriteLine(num.Key);
                    return;
                }
            }
        }
    }
}
