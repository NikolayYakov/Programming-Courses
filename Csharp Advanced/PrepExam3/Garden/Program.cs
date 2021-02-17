using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] garden = new int[size[0], size[1]];
            Fill(garden);
            string command = Console.ReadLine();
            List<int> bloomers = new List<int>();
            while (command != "Bloom Bloom Plow")
            {
                int[] cordinates = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (isInside(garden, cordinates[0], cordinates[1]))
                {
                    bloomers.Add(cordinates[0]);
                    bloomers.Add(cordinates[1]);
                }
                command = Console.ReadLine();
            }
            for(int i = 0; i < bloomers.Count; i += 2)
            {
                garden[bloomers[i], bloomers[i + 1]] += 1;
                 for(int j = bloomers[i] - 1; j >= 0; j--)
                 {
                    garden[j, bloomers[i+1]] += 1;
                 }
                 for(int j = bloomers[i] + 1; j < garden.GetLength(0); j++)
                 {
                    garden[j, bloomers[i + 1]] += 1;
                 }
                 for(int j = bloomers[i + 1]-1; j >= 0; j--)
                 {
                    garden[bloomers[i], j] += 1;
                 }
                 for(int j =bloomers[i+1]+1;j<garden.GetLength(1);j++)
                 {
                    garden[bloomers[i], j] += 1;
                 }
                 
            }
            for(int row = 0; row < garden.GetLength(0); row++)
            {

                for(int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write(garden[row, col]+" ");
                }
                Console.WriteLine();
            }
            
        }
        static void Fill(int[,] garden)
        {
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    garden[row, col] = 0;
                }
            }
        }
        static bool isInside(int[,] garden, int row, int col)
        {
            if (row >= 0 && row < garden.GetLength(0) && col >= 0 && col < garden.GetLength(1))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid coordinates.");
                return false;
            }
        }

    }
}
