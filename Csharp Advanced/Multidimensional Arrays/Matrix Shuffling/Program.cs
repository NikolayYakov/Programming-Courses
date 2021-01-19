using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rows, col] = line[col];

                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Length == 5)
                {
                    int firstRow = int.Parse(command[1]);
                    int firstCol = int.Parse(command[2]);
                    int secondRow = int.Parse(command[3]);
                    int secondCol = int.Parse(command[4]);
                    if (firstRow >= 0 && firstCol >= 0 && secondRow >= 0 && secondCol >= 0 && firstRow < matrix.GetLength(0) && secondRow < matrix.GetLength(0) && firstCol < matrix.GetLength(1) && secondCol < matrix.GetLength(1))
                    {
                        string swaped = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = swaped;
                        for(int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for(int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
