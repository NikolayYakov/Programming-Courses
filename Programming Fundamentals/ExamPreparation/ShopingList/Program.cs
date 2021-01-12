using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                                            .Split("!", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();
            string text = Console.ReadLine();
            while(text!="Go Shopping!")
            {
                string[] command = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string item = command[1];
                switch (command[0].ToLower())
                {
                    case "urgent":
                        Urgent(groceries, item);
                        break;
                    case "unnecessary":
                        Unnecessary(groceries, item);
                        break;
                    case "correct":
                        string newItem = command[2];
                        Correct(groceries, item, newItem);
                        break;
                    case "rearrange":
                        Rearrange(groceries, item);
                        break;
                }
                text = Console.ReadLine();
            
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
        static void  Urgent(List<string> groceries,string item)
        {
            if (!groceries.Contains(item))
            {
                groceries.Insert(0, item);
            }
        }
        static void Unnecessary(List<string> groceries,string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
            }
        }
        static void Correct(List<string> groceries,string oldItem,string newItem)
        {
            if (groceries.Contains(oldItem))
            {
                int index = groceries.IndexOf(oldItem);
                groceries[index] = newItem;
            }
        }
        static void Rearrange(List<string> groceries,string item)
        {
            if (groceries.Contains(item))
            {
                int index = groceries.IndexOf(item);
                groceries.Add(item);
                groceries.RemoveAt(index);
            }
        }
    }
}
