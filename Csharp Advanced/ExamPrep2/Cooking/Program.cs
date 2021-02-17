using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> liquidsQueue = new Queue<int>(liquids);
            Stack<int> ingredientsStack = new Stack<int>(ingredients);
            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;
            while (Math.Min(liquidsQueue.Count, ingredientsStack.Count) > 0)
            {
                int liquid = liquidsQueue.Peek();
                int ingredient = ingredientsStack.Peek();
                int sum = liquid + ingredient;
                if (sum == 25)
                {
                    bread++;
                    liquidsQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else if (sum == 50)
                {
                    cake++;
                    liquidsQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else if (sum == 75)
                {
                    pastry++;
                    liquidsQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else if (sum == 100)
                {
                    fruitPie++;
                    liquidsQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else
                {
                    liquidsQueue.Dequeue();
                    ingredientsStack.Pop();
                    ingredient += 3;
                    ingredientsStack.Push(ingredient);

                }
            }
            if (bread > 0 && cake > 0 && pastry > 0 && fruitPie > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");

            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquidsQueue.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquidsQueue)}");
            }
            if (ingredientsStack.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredientsStack)}");
            }
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");


        }
    }
}
