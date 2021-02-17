using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            int startRow = -1;
            int startCol = -1;
            int pollinateFlowers = 0;
            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for(int col = 0; col < n; col++)
                {
                    field[row, col] = line[col];
                    if (line[col] == 'B')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }

            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "up")
                {
                    field[startRow, startCol] = '.';
                    if (isInside(field, startRow - 1, startCol) == true)
                    {
                        startRow--;
                        if (field[startRow, startCol] == 'f')
                        {
                            pollinateFlowers++;
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == '.')
                        {
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == 'O')
                        {
                            field[startRow, startCol] = 'B';
                            if (isInside(field, startRow - 1, startCol) == true)
                            {
                                field[startRow, startCol] = '.';
                                startRow--;
                                if (field[startRow, startCol] == 'f')
                                {
                                    pollinateFlowers++;
                                    
                                }
                                field[startRow, startCol] = 'B';
                            }
                            else
                            {
                                field[startRow, startCol] = '.';
                                Console.WriteLine("The bee got lost!");

                                break;
                            }
                        }
                    }
                    else
                    {
                        field[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");

                        break;
                    }
                    
                }
                if (command == "down")
                {
                    field[startRow, startCol] = '.';
                    if (isInside(field, startRow + 1, startCol) == true)
                    {
                        startRow++;
                        if (field[startRow, startCol] == 'f')
                        {
                            pollinateFlowers++;
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == '.')
                        {
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == 'O')
                        {
                            field[startRow, startCol] = 'B';
                            if (isInside(field, startRow + 1, startCol) == true)
                            {
                                field[startRow, startCol] = '.';
                                startRow++;
                                if (field[startRow, startCol] == 'f')
                                {
                                    pollinateFlowers++;

                                }
                                field[startRow, startCol] = 'B';
                            }
                            else
                            {
                                field[startRow, startCol] = '.';
                                Console.WriteLine("The bee got lost!");

                                break;
                            }
                        }
                    }
                    else
                    {
                        field[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");

                        break;
                    }

                }
                if (command == "left")
                {
                    field[startRow, startCol] = '.';
                    if (isInside(field, startRow, startCol-1) == true)
                    {
                        startCol--;
                        if (field[startRow, startCol] == 'f')
                        {
                            pollinateFlowers++;
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == '.')
                        {
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == 'O')
                        {
                            field[startRow, startCol] = 'B';
                            if (isInside(field, startCol - 1, startCol) == true)
                            {
                                field[startRow, startCol] = '.';
                                startCol--;
                                if (field[startRow, startCol] == 'f')
                                {
                                    pollinateFlowers++;

                                }
                                field[startRow, startCol] = 'B';
                            }
                            else
                            {
                                field[startRow, startCol] = '.';
                                Console.WriteLine("The bee got lost!");

                                break;
                            }
                        }
                    }
                    else
                    {
                        field[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");

                        break;
                    }

                }
                if (command == "right")
                {
                    field[startRow, startCol] = '.';
                    if (isInside(field, startRow, startCol + 1) == true)
                    {
                        startCol++;
                        if (field[startRow, startCol] == 'f')
                        {
                            pollinateFlowers++;
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == '.')
                        {
                            field[startRow, startCol] = 'B';
                        }
                        if (field[startRow, startCol] == 'O')
                        {
                            field[startRow, startCol] = 'B';
                            if (isInside(field, startCol + 1, startCol) == true)
                            {
                                field[startRow, startCol] = '.';
                                startCol++;
                                if (field[startRow, startCol] == 'f')
                                {
                                    pollinateFlowers++;

                                }
                                field[startRow, startCol] = 'B';
                            }
                            else
                            {
                                field[startRow, startCol] = '.';
                                Console.WriteLine("The bee got lost!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        field[startRow, startCol] = '.';
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                }
                command = Console.ReadLine();
            }
            if (pollinateFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinateFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinateFlowers} flowers more");
            }
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
            
        }
        static bool isInside(char[,] field,int row,int col)
        {
            if (row < field.GetLength(0) && col < field.GetLength(1) && row>=0 && col>=0)
            {
                return true;
            }
            return false;
        }
    }
}
