using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int startRow = -1;
            int startCol = -1;
            int food = 0;
            bool isOut = false;
            for(int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for(int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            while (food<10)
            {
                string command = Console.ReadLine();
                matrix[startRow, startCol] = '.';
                if (command== "up")
                {
                    if (isInside(n, startRow - 1, startCol))
                    {
                        startRow -= 1;
                        if (matrix[startRow, startCol] == '*')
                        {
                            food++;
                            matrix[startRow, startCol] = 'S';
                        }
                        else if (matrix[startRow, startCol] == 'B')
                        {
                            matrix[startRow, startCol] = '.';
                            for(int row = 0; row < n; row++)
                            {
                                for(int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        startRow = row;
                                        startCol = col;
                                        matrix[startRow, startCol] = 'S';

                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[startRow, startCol] = 'S';
                        }

                    }
                    else
                    {
                        isOut = true;
                        break;
                        
                    }
                }
                if (command == "down")
                {
                    if (isInside(n, startRow + 1, startCol))
                    {
                        startRow += 1;
                        if (matrix[startRow, startCol] == '*')
                        {
                            food++;
                            matrix[startRow, startCol] = 'S';
                        }
                        else if (matrix[startRow, startCol] == 'B')
                        {
                            matrix[startRow, startCol] = '.';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        startRow = row;
                                        startCol = col;
                                        matrix[startRow, startCol] = 'S';

                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[startRow, startCol] = 'S';
                        }

                    }
                    else
                    {
                        isOut = true;
                        break;
                        
                    }
                }
                if (command == "left")
                {
                    if (isInside(n, startRow, startCol-1))
                    {
                        startCol -= 1;
                        if (matrix[startRow, startCol] == '*')
                        {
                            food++;
                            matrix[startRow, startCol] = 'S';
                        }
                        else if (matrix[startRow, startCol] == 'B')
                        {
                            matrix[startRow, startCol] = '.';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        startRow = row;
                                        startCol = col;
                                        matrix[startRow, startCol] = 'S';

                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[startRow, startCol] = 'S';
                        }

                    }
                    else
                    {
                        isOut = true;
                        break;
                        
                    }
                }
                if (command == "right")
                {
                    if (isInside(n, startRow, startCol+1))
                    {
                        startCol += 1;
                        if (matrix[startRow, startCol] == '*')
                        {
                            food++;
                            matrix[startRow, startCol] = 'S';
                        }
                        else if (matrix[startRow, startCol] == 'B')
                        {
                            matrix[startRow, startCol] = '.';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (matrix[row, col] == 'B')
                                    {
                                        startRow = row;
                                        startCol = col;
                                        matrix[startRow, startCol] = 'S';

                                    }
                                }
                            }
                        }
                        else
                        {
                            matrix[startRow, startCol] = 'S';
                        }

                    }
                    else
                    {
                        isOut = true;
                        break;
                         
                    }
                }
            }
            if(isOut == true)
            {
                Console.WriteLine("Game over!");
            }
            else if (food >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {food}");
            for(int row=0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static bool isInside(int n,int row,int col)
        {
            if (row >= 0 && row < n && col >= 0 && col < n)
            {

                return true;
            }
            return false;
        }
    }
}
