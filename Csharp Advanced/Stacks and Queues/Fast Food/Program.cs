using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] oredrs = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();
            Queue<int> customers = new Queue<int>(oredrs);
            Console.WriteLine(customers.Max());
            while (customers.Count > 0)
            {
                int order = customers.Peek();
                if (food - order < 0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",customers.ToArray())}");
                    break;
                }
                else
                {
                    food -= order;
                    customers.Dequeue();
                }
 
                
            }
            if (customers.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
