using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandCount = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int startRow = -1;
            int startCol = -1;
            bool isWon = false;
            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'f')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            for (int i = 0; i < commandCount; i++)
            {
                string command = Console.ReadLine();
                matrix[startRow, startCol] = '-';
                if (command == "up")
                {
                    if (startRow - 1 < 0)
                    {
                        startRow = n - 1;
                    }
                    else
                    {
                        startRow--;
                    }
                    if (matrix[startRow, startCol] == 'F')
                    {
                        matrix[startRow, startCol] = 'f';
                        isWon = true;
                        break;
                    }
                    else if (matrix[startRow, startCol] == 'B')
                    {
                        if (startRow - 1 < 0)
                        {
                            startRow = n - 1;
                        }
                        else
                        {
                            startRow--;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    else if (matrix[startRow, startCol] == 'T')
                    {
                        if (startRow + 1 > n - 1)
                        {
                            startRow = 0;
                        }
                        else
                        {
                            startRow++;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    matrix[startRow, startCol] = 'f';
                }
                if (command == "down")
                {
                    if (startRow + 1 > n - 1)
                    {
                        startRow = 0;
                    }
                    else
                    {
                        startRow++;
                    }
                    if (matrix[startRow, startCol] == 'F')
                    {
                        matrix[startRow, startCol] = 'f';
                        isWon = true;
                        break;
                    }
                    else if (matrix[startRow, startCol] == 'B')
                    {
                        if (startRow + 1 > n - 1)
                        {
                            startRow = 0;
                        }
                        else
                        {
                            startRow++;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    else if (matrix[startRow, startCol] == 'T')
                    {
                        if (startRow - 1 < 0)
                        {
                            startRow = n - 1;
                        }
                        else
                        {
                            startRow--;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    matrix[startRow, startCol] = 'f';
                }

                if (command == "left")
                {
                    if (startCol - 1 < 0)
                    {
                        startCol = n - 1;
                    }
                    else
                    {
                        startCol--;
                    }
                    if (matrix[startRow, startCol] == 'F')
                    {
                        matrix[startRow, startCol] = 'f';
                        isWon = true;
                        break;
                    }
                    else if (matrix[startRow, startCol] == 'B')
                    {
                        if (startCol - 1 < 0)
                        {
                            startCol = n - 1;
                        }
                        else
                        {
                            startCol--;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    else if (matrix[startRow, startCol] == 'T')
                    {
                        if (startCol + 1 > n - 1)
                        {
                            startCol = 0;
                        }
                        else
                        {
                            startCol++;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    matrix[startRow, startCol] = 'f';
                }
                if (command == "right")
                {
                    if (startCol + 1 > n - 1)
                    {
                        startCol = 0;
                    }
                    else
                    {
                        startCol++;
                    }
                    if (matrix[startRow, startCol] == 'F')
                    {
                        matrix[startRow, startCol] = 'f';
                        isWon = true;
                        break;
                    }
                    else if (matrix[startRow, startCol] == 'B')
                    {
                        if (startCol + 1 > n - 1)
                        {
                            startCol = 0;
                        }
                        else
                        {
                            startCol++;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    else if (matrix[startRow, startCol] == 'T')
                    {
                        if (startCol - 1 < 0)
                        {
                            startCol = n - 1;
                        }
                        else
                        {
                            startCol--;
                        }
                        if (matrix[startRow, startCol] == 'F')
                        {
                            matrix[startRow, startCol] = 'f';
                            isWon = true;
                            break;
                        }
                    }
                    matrix[startRow, startCol] = 'f';
                }
            
            }
            if (isWon == true)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
