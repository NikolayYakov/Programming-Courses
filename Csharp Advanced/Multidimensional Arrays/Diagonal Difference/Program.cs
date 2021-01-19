using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int rightDiagonalSum = 0;
            int leftDiagonalSum = 0;
            int collon = n - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                rightDiagonalSum += matrix[i, i];
            }
            for(int row = 0; row < matrix.GetLength(0); row++)
            {

                leftDiagonalSum += matrix[row, collon];
                collon -= 1;
            }
            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
