using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
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
            Queue<int> queueNumber = new Queue<int>(numbers);
            for (int i = 0; i < conditionNumbers[1]; i++)
            {
                if (queueNumber.Count == 0)
                {
                    break;
                }
                queueNumber.Dequeue();
            }
            if (queueNumber.Contains(conditionNumbers[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queueNumber.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queueNumber.Min());
                }

            }
        }
    }
}
