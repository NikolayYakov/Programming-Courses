using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] conditionNumbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int[] numbers = new int[conditionNumbers[0]];
            numbers = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();
            Stack<int> stackNumber = new Stack<int>(numbers);
            for (int i = 0; i < conditionNumbers[1]; i++)
            {
                if (stackNumber.Count == 0)
                {
                    break;
                }
                stackNumber.Pop();
            }
            if (stackNumber.Contains(conditionNumbers[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stackNumber.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stackNumber.Min());
                }

            }

        }
    }
}
