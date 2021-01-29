using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            int divide = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> reverse = Reverse;
            reverse(numbers);
            Func<int, bool> removed = n => n % divide == 0;
            numbers = Remove(numbers, removed, divide);
            Console.WriteLine(string.Join(" ", numbers));
        }
        static List<int> Reverse(List<int>numbers)
        {
            numbers.Reverse();
            return numbers;
        }
        static List<int> Remove(List<int> numbers,Func<int,bool> removed,int divide)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if (removed(numbers[i]))
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            return numbers;
        }
    }
}
