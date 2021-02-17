using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] bakery = new char[n, n];
            int startRow = -1;
            int startCol = -1;
            int money = 0;
            bool isOut = false;
            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = line[col];
                    if (bakery[row, col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            
            while (true)
            {
                string command = Console.ReadLine();
                bakery[startRow, startCol] = '-';
                if (command == "up")
                {
                    if (isInside(bakery, startRow - 1, startCol))
                    {
                        startRow--;
                        if (char.IsDigit(bakery[startRow, startCol]))
                        {
                            money += int.Parse(bakery[startRow, startCol].ToString());
                        }
                        if (bakery[startRow, startCol] == 'O')
                        {
                            bakery[startRow, startCol] = '-';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (bakery[row, col] == 'O')
                                    {
                                        startRow = row;
                                        startCol = col;
                                    }
                                }
                            }
                        }
                        bakery[startRow, startCol] = 'S';
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                    
                   
                   
                }
                if (command == "down")
                {
                    if (isInside(bakery, startRow + 1, startCol))
                    {
                        startRow++;
                        if (char.IsDigit(bakery[startRow, startCol]))
                        {
                            money += int.Parse(bakery[startRow, startCol].ToString());
                        }
                        if (bakery[startRow, startCol] == 'O')
                        {
                            bakery[startRow, startCol] = '-';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (bakery[row, col] == 'O')
                                    {
                                        startRow = row;
                                        startCol = col;
                                    }
                                }
                            }
                        }
                        bakery[startRow, startCol] = 'S';
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }
                if (command == "right")
                {
                    if (isInside(bakery, startRow, startCol + 1))
                    {
                        startCol++;
                        if (char.IsDigit(bakery[startRow, startCol]))
                        {
                            money += int.Parse(bakery[startRow, startCol].ToString());
                        }
                        if (bakery[startRow, startCol] == 'O')
                        {
                            bakery[startRow, startCol] = '-';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (bakery[row, col] == 'O')
                                    {
                                        startRow = row;
                                        startCol = col;
                                    }
                                }
                            }
                        }
                        bakery[startRow, startCol] = 'S';
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }
                if (command == "left")
                {
                    if (isInside(bakery, startRow, startCol - 1))
                    {
                        startCol--;
                        if (char.IsDigit(bakery[startRow, startCol]))
                        {
                            money += int.Parse(bakery[startRow, startCol].ToString());
                        }
                        if (bakery[startRow, startCol] == 'O')
                        {
                            bakery[startRow, startCol] = '-';
                            for (int row = 0; row < n; row++)
                            {
                                for (int col = 0; col < n; col++)
                                {
                                    if (bakery[row, col] == 'O')
                                    {
                                        startRow = row;
                                        startCol = col;
                                    }
                                }
                            }
                        }
                        bakery[startRow, startCol] = 'S';
                    }
                    else
                    {
                        isOut = true;
                        break;
                    }
                }
                if (money >= 50)
                {
                    break;
                }

            }

            if (isOut == true)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            if (money >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {money}");
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }

        }
        static bool isInside(char[,] bakery,int row,int col)
        {
            if (row >= 0 && col >= 0 && row < bakery.GetLength(0) && col < bakery.GetLength(1))
            {
                return true;
            }
            return false;
        }
         
    }
}
