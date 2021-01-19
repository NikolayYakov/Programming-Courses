using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] field = new char[size[0], size[1]];
            int startRow = 0;
            int startCol = 0;
            bool isDeath = false;
            bool isAlive = false;
            for(int row = 0; row < size[0]; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for(int col = 0; col < size[1]; col++)
                {
                    field[row, col] = line[col];
                    if (field[row, col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            char[] commands = Console.ReadLine().ToCharArray();
            Queue<char> commandQueue = new Queue<char>(commands);
            while (commandQueue.Count > 0)
            {
                string command = commandQueue.Dequeue().ToString();
                if (command == "U")
                {
                    if (IsInside(field, startRow - 1, startCol))
                    {
                        field[startRow, startCol] = '.';
                        startRow = startRow - 1;
                        if (field[startRow, startCol] == 'B')
                        {
                            isDeath = true;
                             

                        }
                        else
                        {
                            field[startRow, startCol] = 'P';
                        }
                    }
                    else
                    {
                        isAlive = true;
                        field[startRow, startCol] = '.';
                        

                    }
                }
                else   if (command == "D")
                {
                    if (IsInside(field, startRow + 1, startCol))
                    {
                        field[startRow, startCol] = '.';
                        startRow = startRow + 1;
                        if (field[startRow, startCol] == 'B')
                        {
                            isDeath = true;
                            
                        }
                        else
                        {
                            field[startRow, startCol] = 'P';
                        }
                    }
                    else
                    {
                        isAlive = true;
                        field[startRow, startCol] = '.';
                        

                    }
                }
                else  if (command == "L")
                {
                    if (IsInside(field, startRow, startCol - 1))
                    {
                        field[startRow, startCol] = '.';
                        startCol = startCol - 1;
                        if (field[startRow, startCol] == 'B')
                        {
                            isDeath = true;
                            
                        }
                        else
                        {
                            field[startRow, startCol] = 'P';
                        }
                    }
                    else
                    {
                        isAlive = true;
                        field[startRow, startCol] = '.';

                    }
                }
                else if (command == "R")
                {
                    if (IsInside(field, startRow, startCol + 1))
                    {
                        field[startRow, startCol] = '.';
                        startCol = startCol + 1;
                        if (field[startRow, startCol] == 'B')
                        {
                            isDeath = true;
                        }
                        else
                        {
                            field[startRow, startCol] = 'P';
                        }
                    }
                    else
                    {
                        isAlive = true;
                        field[startRow, startCol] = '.';
                    }
                }
                for(int row = 0; row < size[0]; row++)
                {
                    for(int col = 0; col < size[1]; col++)
                    {
                        if (field[row, col] == 'B')
                        {
                            if (IsInside(field, row + 1, col)&&field[row+1,col]!='B')
                            {
                                if (field[row + 1, col] == 'P')
                                {
                                    isDeath = true;
                                  
                                }
                                field[row + 1, col] = 'b';
                            }
                            if (IsInside(field, row - 1, col)&&field[row-1,col]!='B')
                            {
                                if (field[row - 1, col] == 'P')
                                {
                                    isDeath = true;

                                }
                                field[row - 1, col] = 'b';
                            }
                            if (IsInside(field, row, col -1 )&&field[row,col-1]!='B')
                            {
                                if (field[row, col - 1] == 'P')
                                {
                                    isDeath = true;

                                }
                                field[row, col - 1] = 'b';
                            }
                            if (IsInside(field, row, col + 1)&&field[row,col+1]!='B')
                            {
                                if (field[row, col + 1] == 'P')
                                {
                                    isDeath = true;

                                }
                                field[row, col + 1] = 'b';
                            }
                        }
                         
                    }
                }
                for(int row = 0; row < size[0]; row++)
                {
                    for(int col = 0; col < size[1]; col++)
                    {
                        if (field[row, col] == 'b')
                        {
                            field[row, col] = 'B';
                        }
                    }
                }
                if (isAlive == true || isDeath == true)
                {
                    break;
                }
            }
            for(int row = 0; row < size[0]; row++)
            {
                for(int col = 0; col < size[1]; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
            if(isAlive == true)
            {
                Console.WriteLine($"won: {startRow} {startCol}");
            }
            else if(isDeath == true)
            {
                Console.WriteLine($"dead: {startRow} {startCol}");
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
