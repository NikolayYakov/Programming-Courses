using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (firstSet.Contains(number))
                {
                    secondSet.Add(number);
                }
                
            }
            foreach ( var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write(num+" ");
                }
            }
            
            

        }
    }
}
