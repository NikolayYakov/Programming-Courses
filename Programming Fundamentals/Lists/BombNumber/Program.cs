using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            List<int> bombNumber = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            int bomb = bombNumber[0];
            int power = bombNumber[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber == bomb)
                {
                    int statrIndex = i - power;
                    int endIndex = i + power;
                    if (statrIndex < 0)
                    {
                        statrIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    int endIndexToRemove =endIndex-statrIndex+1;
                    numbers.RemoveRange(statrIndex, endIndexToRemove);
                    i = statrIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
