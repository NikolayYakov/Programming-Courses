using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> commandQueue = new Queue<string>(commands);
            int startRow = 0;
            int startCol = 0;
            int coal = 0;
            bool textWriten = false;
            for(int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for(int col = 0; col < n; col++)
                {
                    field[row, col] = line[col];
                    if (field[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (field[row, col] == 'c')
                    {
                        coal++;
                    }
                }
            }
            while (commandQueue.Count > 0)
            {
                bool isChanged = false;
                string command = commandQueue.Dequeue();
                if (command == "up"&&IsInside(field,startRow - 1,startCol))
                {
                    startRow = startRow - 1;
                    startCol = startCol;
                    isChanged = true;
                }
                else if (command == "down" && IsInside(field, startRow + 1, startCol))
                {
                    startRow = startRow + 1;
                    startCol = startCol;
                    isChanged = true;
                }
                else  if (command == "left" && IsInside(field, startRow, startCol - 1))
                {
                    startRow = startRow;
                    startCol = startCol - 1;
                    isChanged = true;
                }
                else if (command == "right" && IsInside(field, startRow, startCol + 1))
                {
                    startRow = startRow;
                    startCol = startCol + 1;
                    isChanged = true;
                }
                if (isChanged == true)
                {
                    string symbol = field[startRow, startCol].ToString();
                    if (symbol == "e")
                    {
                        Console.WriteLine($"Game over! {(startRow, startCol)}");
                        textWriten = true;
                    }
                    else if (symbol == "c")
                    {
                        coal--;
                        field[startRow, startCol] = '*';
                    }
                    if (coal == 0)
                    {
                        Console.WriteLine($"You collected all coals! {(startRow, startCol)}");
                        textWriten = true;
                    }
                }
            }
            if (textWriten == false)
            {
                Console.WriteLine($"{coal} coals left. ({startRow}, {startCol})");
            }
        }
        static bool IsInside(char[,] field, int row, int col)
        {
            if (row >= 0 && col >= 0 && row < field.GetLength(0) && col < field.GetLength(1))
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
