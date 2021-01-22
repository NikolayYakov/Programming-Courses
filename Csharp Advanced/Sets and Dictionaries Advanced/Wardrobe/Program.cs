using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrob = new Dictionary<string, Dictionary<string, int>>();
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                string[] colorItem = Console.ReadLine().Split(" -> ");
                string[] items = colorItem[1].Split(",");
                if (!wardrob.ContainsKey(colorItem[0]))
                {
                    wardrob.Add(colorItem[0], new Dictionary<string, int>());
                }
                for(int j=0; j < items.Length; j++)
                {
                    if (!wardrob[colorItem[0]].ContainsKey(items[j]))
                    {
                        wardrob[colorItem[0]].Add(items[j], 0);
                    }
                    wardrob[colorItem[0]][items[j]]++;
                }
            }
            string[] searching = Console.ReadLine().Split();
            foreach (var item in wardrob)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (item.Key == searching[0] && cloth.Key == searching[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");

                    }
                }
            }
        }
    }
}
