using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            string[] bombsCordinats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> bombs = new Queue<string>(bombsCordinats);
            int aliveCount = 0;
            int aliveSum = 0;
            while(bombs.Count>0)
            {
                int[] bomb = bombs.Dequeue().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = bomb[0];
                int col = bomb[1];
                if (IsInside(matrix, row, col)&&matrix[row,col]>0)
                {
                    if (IsInside(matrix, row - 1, col - 1) && matrix[row-1,col-1]>0)
                    {
                        matrix[row - 1, col - 1] -= matrix[row, col];

                    }
                    if (IsInside(matrix, row - 1, col) && matrix[row-1,col]>0)
                    {
                        matrix[row - 1, col] -= matrix[row, col];

                    }
                    if (IsInside(matrix, row - 1, col + 1) && matrix[row-1,col+1]>0)
                    {
                        matrix[row - 1, col + 1] -= matrix[row, col];
                        
                    }
                    if (IsInside(matrix, row, col - 1) && matrix[row,col-1]>0)
                    {
                        matrix[row, col - 1] -= matrix[row, col];

                    }
                    if (IsInside(matrix, row, col + 1) && matrix[row,col+1]>0)
                    {
                        matrix[row, col + 1] -= matrix[row, col];
                         
                    }
                    if (IsInside(matrix, row + 1, col - 1) && matrix[row+1,col-1]>0)
                    {
                        matrix[row + 1, col - 1] -= matrix[row, col];
                         

                    }
                    if (IsInside(matrix, row + 1, col) && matrix[row+1,col]>0)
                    {
                        matrix[row + 1, col] -= matrix[row, col];
                       

                    }
                    if (IsInside(matrix, row + 1, col + 1) && matrix[row+1,col+1]>0)
                    {
                        matrix[row + 1, col + 1] -= matrix[row, col];
                        

                    }
                    matrix[row, col] = 0;
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {    
                    if (matrix[row, col] > 0)
                    {
                        aliveCount++;
                        aliveSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCount}");
            Console.WriteLine($"Sum: {aliveSum}");
            for (int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }


        }
        static bool IsInside(int[,] matrix, int row, int col)
        {
            if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
