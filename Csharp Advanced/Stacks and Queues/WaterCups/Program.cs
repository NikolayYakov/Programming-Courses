using System;
using System.Collections.Generic;
using System.Linq;

namespace WaterCups
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int[] waterBottle = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            Stack<int> waterStack = new Stack<int>(waterBottle);
            Stack<int> cupsStack = new Stack<int>(cups.Reverse());
            int wastedWater = 0;
            while (waterStack.Count > 0 && cupsStack.Count > 0)
            {
                int water = waterStack.Pop();
                int cup = cupsStack.Pop();
                cup -= water;
                if (cup <= 0)
                {
                    wastedWater += Math.Abs(cup);
                }
                else
                {
                    cupsStack.Push(cup);
                }
            }
            if (waterStack.Count > 0)
            {
                Console.WriteLine($"Bottles: {waterStack.Sum()}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cupsStack.ToArray())}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
