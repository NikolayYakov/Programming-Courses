using System;
using System.Collections.Generic;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<double>> order = new Dictionary<string, List<double>>();
            while (command[0] != "buy")
            {
                string product = command[0];
                double price = double.Parse(command[1]);
                double count = double.Parse(command[2]);
                if (order.ContainsKey(product))
                {
                    order[product][0] = price;
                    order[product][1] += count;
                }
                else
                {
                    order.Add(product, new List<double>(2));
                    order[product].Insert(0, price);
                    order[product].Insert(1, count);
                }
                command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in order)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[1] * item.Value[0]):f2}");
            }
        }
    }
}
