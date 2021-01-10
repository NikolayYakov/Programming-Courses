using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int listSize = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(listSize);
            for(int i = 0; i < listSize; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
             
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
                
            }
        }
    }
}
