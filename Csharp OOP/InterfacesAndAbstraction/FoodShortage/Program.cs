using System;
using System.Collections.Generic;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> people = new List<IBuyer>();
            for(int i = 0; i < n; i++)
            {
                IBuyer buyer = null;
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command.Length == 4)
                {
                    buyer = new Citizen(command[0], int.Parse(command[1]), command[2], command[3]);
                }
                else
                {
                    buyer = new Rebel(command[0], int.Parse(command[1]), command[2]);
                }
                people.Add(buyer);
            }
            string data = Console.ReadLine();
            while (data != "End")
            {
                foreach (var item in people)
                {
                    if (item.Name == data)
                    {
                        item.BuyFood();
                    }
                }
                data = Console.ReadLine();
            }
            int food = 0;
            foreach (var item in people)
            {
                food += item.Food;
            }
            Console.WriteLine(food);
        }
    }
}
