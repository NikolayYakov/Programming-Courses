using System;
using System.Collections.Generic;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            foreach (var item in Combinations(3, 5))
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
        static IEnumerable<int[]> Combinations(int k,int n)
        {
            var result = new int[k];
            var stack = new Stack<int>();
            stack.Push(1);
            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var value = stack.Pop();
                while (value <= n)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index == k)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }
    }
}
