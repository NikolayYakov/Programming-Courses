using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            for(int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for(int col = 0; col < n; col++)
                {
                    board[row, col] = line[col];
                }
            }
            int knightsRemoved = 0;

            int maxAttacks = 0;
            int killerRow = 0;
            int killerCol = 0;
            int attack = 0;
            while (true)
            {
                for (int row = 0; row < n; row++)
                {
                    for(int col = 0; col < n; col++)
                    {
                        
                        if (board[row, col] == 'K')
                        {
                            if (IsInside(board, row - 2, col + 1))
                            {
                                if (board[row - 2, col + 1] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row - 2, col - 1))
                            {
                                if (board[row - 2, col - 1] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row + 1, col + 2))
                            {
                                if (board[row + 1, col + 2] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row + 1, col - 2))
                            {
                                if (board[row + 1, col - 2] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row - 1, col + 2))
                            {
                                if (board[row - 1, col + 2] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row - 1, col - 2))
                            {
                                if (board[row - 1, col - 2] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row + 2, col - 1))
                            {
                                if (board[row + 2, col - 1] == 'K')
                                {
                                    attack++;
                                }
                            }
                            if (IsInside(board, row + 2, col + 1))
                            {
                                if (board[row + 2, col + 1] == 'K')
                                {
                                    attack++;
                                }
                            }
                        }
                        if (attack > maxAttacks)
                        {
                            maxAttacks = attack;
                            killerRow = row;
                            killerCol = col;
                        }
                        attack = 0;
                    }
                     
                }
                if (maxAttacks != 0)
                {
                    board[killerRow, killerCol] = '0';
                    knightsRemoved++;
                    maxAttacks = 0;
                }
                else
                {
                    Console.WriteLine(knightsRemoved);
                    return;
                }

            }
        }
        static bool IsInside(char[,] board,int row,int col)
        {
            if (row >= 0 && col >= 0 && row < board.GetLength(0) && col < board.GetLength(1))
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
