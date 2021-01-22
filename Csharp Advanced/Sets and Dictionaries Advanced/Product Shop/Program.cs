using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string[] command = Console.ReadLine().Split(", ");
            while(command[0]!= "Revision")
            {
                string shopName = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);
                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }
                if (shops[shopName].ContainsKey(product))
                {
                    shops[shopName][product] = price;
                }
                else
                {
                    shops[shopName].Add(product, price);
                }
                
                command = Console.ReadLine().Split(", ");
            }
            foreach (var shop in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");

                }
            }
        }
    }
}
