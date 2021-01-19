using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = row[col];
                    sum += matrix[rows, col];
                }
            }
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(sum);
        }
    }
}
