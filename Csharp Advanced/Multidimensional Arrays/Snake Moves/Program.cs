using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            string input = Console.ReadLine();
            int currLetter = 0;
            for(int row = 0; row < size[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for(int col = 0; col < size[1]; col++)
                    {
                        matrix[row, col] = input[currLetter];
                        currLetter++;
                        if (currLetter == input.Length)
                        {
                            currLetter = 0;
                            
                        }
                    }
                }
                else
                {
                    for(int col = size[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = input[currLetter];
                        currLetter++;
                        if (currLetter == input.Length)
                        {
                            currLetter = 0;
                            
                        }
                    }
                }
            }
            for(int row = 0; row < size[0]; row++)
            {
                for(int col = 0; col < size[1]; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
