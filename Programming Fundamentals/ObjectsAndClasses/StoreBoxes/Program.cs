using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "end")
            {
                string serialNumber = command[0];
                string product = command[1];
                int quantity = int.Parse(command[2]);
                double itemPrice = double.Parse(command[3]);
                boxes.Add(new Box(serialNumber, new Item(product, itemPrice), quantity));


                command = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            List<Box> ordered = boxes.OrderByDescending(b=>b.Price)
                 .ToList();
            foreach (Box item in ordered)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.Price:f2}");
            }
            
                 

        }
    }
    class Item
    {
        public Item(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public  double Price { get; set; }
    }
    class Box
    {
        public Box(string serialNumber,Item item,int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double Price { get { return Item.Price * Quantity; } }

    }
}
