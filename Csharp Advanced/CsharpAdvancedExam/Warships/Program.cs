using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] cordinates = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            char[,] field = new char[n, n];
            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            int totalDestroyedShips = 0;
            for(int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for(int col = 0; col < n; col++)
                {
                    field[row, col] = line[col];
                    if (line[col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (line[col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }
            for(int i = 0; i < cordinates.Length; i++)
            {
                int[] cords = cordinates[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = cords[0];
                int col = cords[1];
                if (isInside(n, row, col))
                {
                    if (field[row, col] == '<')
                    {
                        firstPlayerShips--;
                        totalDestroyedShips++;

                        field[row, col] = 'X';
                    }
                    else if (field[row, col] == '>')
                    {
                        secondPlayerShips--;
                        totalDestroyedShips++;

                        field[row, col] = 'X';
                    }
                    else if(field[row,col]== '#')
                    {
                        if (isInside(n, row - 1, col))
                        {
                            if (field[row - 1, col] == '<')
                            {
                                field[row - 1, col] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;
                                 



                            }
                            else if(field[row - 1, col] == '>')
                            {
                                field[row - 1, col] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;
                                 


                            }

                        }
                        if (isInside(n, row + 1, col))
                        {
                            if (field[row + 1, col] == '<')
                            {
                                field[row + 1, col] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;
                                


                            }
                            else if (field[row + 1, col] == '>')
                            {
                                field[row + 1, col] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;
                                 

                            }

                        }
                        if (isInside(n, row, col-1))
                        {
                            if (field[row, col-1] == '<')
                            {
                                field[row, col-1] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;


                            }
                            else if (field[row, col-1] == '>')
                            {
                                field[row, col-1] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;

                            }
                             
                        }
                        if (isInside(n, row, col + 1))
                        {
                            if (field[row, col + 1] == '<')
                            {
                                field[row, col + 1] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;


                            }
                            else if (field[row, col + 1] == '>')
                            {
                                field[row, col + 1] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;

                            }
                            
                        }
                        if (isInside(n, row-1, col - 1))
                        {
                            if (field[row-1, col - 1] == '<')
                            {
                                field[row-1, col - 1] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;


                            }
                            else if (field[row-1, col - 1] == '>')
                            {
                                field[row-1, col-1] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;

                            }
                             
                        }
                        if (isInside(n, row-1, col + 1))
                        {
                            if (field[row-1, col + 1] == '<')
                            {
                                field[row-1, col + 1] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;


                            }
                            else if (field[row-1, col + 1] == '>')
                            {
                                field[row-1, col + 1] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;

                            }
                        }
                        if (isInside(n, row+1, col - 1))
                        {
                            if (field[row+1, col - 1] == '<')
                            {
                                field[row+1, col - 1] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;


                            }
                            else if (field[row+1, col - 1] == '>')
                            {
                                field[row+1, col - 1] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;

                            }
                        }
                        if (isInside(n, row+1, col + 1))
                        {
                            if (field[row+1, col + 1] == '<')
                            {
                                field[row+1, col + 1] = 'X';
                                firstPlayerShips--;
                                totalDestroyedShips++;


                            }
                            else if (field[row+1, col + 1] == '>')
                            {
                                field[row+1, col + 1] = 'X';
                                secondPlayerShips--;
                                totalDestroyedShips++;

                            }
                        }
                        field[row, col] = 'X';
                    }
                }
                if (firstPlayerShips<=0)
                {
                    break;
                }
                if (secondPlayerShips <= 0)
                {
                    break;
                }
                
            }
            if (firstPlayerShips <= 0)
            {
                Console.WriteLine($"Player Two has won the game! {totalDestroyedShips} ships have been sunk in the battle.");
            }
            else if (secondPlayerShips <= 0)
            {
                Console.WriteLine($"Player One has won the game! {totalDestroyedShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
            }

        }
        static bool isInside(int n, int row,int col)
        {
            if (row >= 0 && row < n && col >= 0 && col < n)
            {
                return true;
            }
            return false;
        }
    }
}
