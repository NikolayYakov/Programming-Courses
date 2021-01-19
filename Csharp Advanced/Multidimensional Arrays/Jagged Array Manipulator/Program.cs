using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagArray = new double[rows][];
            for(int row = 0; row < rows; row++)
            {
                jagArray[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }
            for(int row = 0; row < rows - 1; row++)
            {
                if (jagArray[row].Length == jagArray[row+1].Length)
                {
                    for(int i = 0; i < jagArray[row].Length; i++)
                    {
                        jagArray[row][i] *= 2.0;
                        jagArray[row + 1][i] *= 2.0;
                    }
                }
                else
                {

                    for (int i = 0; i < jagArray[row].Length; i++)
                    {
                        jagArray[row][i] /= 2.0;
                       
                    }
                    for(int i = 0; i < jagArray[row + 1].Length; i++)
                    {
                        jagArray[row+1][i] /= 2.0;
                    }
                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while(command[0]!= "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                double value = int.Parse(command[3]);
                if (row >= 0 && col >= 0 && row < rows && col < jagArray[row].Length)
                {
                    if(command[0]== "Add")
                    {
                        jagArray[row][col] += value;
                    }
                    else if(command[0]== "Subtract")
                    {
                        jagArray[row][col] -= value;
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for(int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", jagArray[row]));
            }

        }
    }
}
