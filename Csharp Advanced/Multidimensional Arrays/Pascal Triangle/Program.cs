using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] paskal = new long[rows][];
            for(int row = 0; row < rows; row++)
            {
                paskal[row] = new long[row+1];
                for(int col = 0;col<=row;col++)
                {
                    if (col == 0||col==row)
                    {
                        paskal[row][col] = 1L;
                    }
                    else
                    {
                        paskal[row][col] = paskal[row - 1][col] + paskal[row - 1][col - 1];
                    }
                    Console.Write(paskal[row][col]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
