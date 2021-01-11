using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory["fragments"] = 0;
            inventory["shards"] = 0;
            inventory["motes"] = 0;
            bool flag = false;
            while (true)
            {
                string[] items = Console.ReadLine()
                                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < items.Length; i += 2)
                {
                    int count = int.Parse(items[i]);
                    string item = items[i + 1].ToLower();
                    if (inventory.ContainsKey(item))
                    {

                        inventory[item] += count;

                    }
                    else
                    {
                        inventory.Add(item, count);
                    }
                    if (inventory.ContainsKey("shards") && inventory["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        inventory["shards"] -= 250;
                        flag = true;
                        break;
                    }
                    else if (inventory.ContainsKey("fragments") && inventory["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        inventory["fragments"] -= 250;
                        flag = true;
                        break;
                    }
                    else if (inventory.ContainsKey("motes") && inventory["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        inventory["motes"] -= 250;
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            Dictionary<string, int> fillter = new Dictionary<string, int>(3);
            fillter["shards"] = inventory["shards"];
            fillter["fragments"] = inventory["fragments"];
            fillter["motes"] = inventory["motes"];
            inventory.Remove("shards");
            inventory.Remove("fragments");
            inventory.Remove("motes");
            foreach (var item in fillter.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in inventory.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }

        }
    }
}
