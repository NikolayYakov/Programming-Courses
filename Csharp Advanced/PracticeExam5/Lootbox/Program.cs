using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondBox = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> firstBoxQueue = new Queue<int>(firstBox);
            Stack<int> secondBoxStack = new Stack<int>(secondBox);
            int value = 0;
            while (Math.Min(firstBoxQueue.Count, secondBoxStack.Count) > 0)
            {
                int sum = 0;
                int firstBoxLoot = firstBoxQueue.Peek();
                int secondBoxLoot = secondBoxStack.Peek();
                sum = firstBoxLoot + secondBoxLoot;
                if (sum % 2 == 0)
                {
                    value += sum;
                    firstBoxQueue.Dequeue();
                    secondBoxStack.Pop();
                }
                else
                {
                    secondBoxStack.Pop();
                    firstBoxQueue.Enqueue(secondBoxLoot);
                }
            }
            if (secondBoxStack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else if(firstBoxQueue.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (value >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }

        }
    }
}
