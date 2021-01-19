using System;
using System.Linq;

namespace JaggedArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row >= 0 && col >= 0 && row < rows && col < jaggedArray[row].Length)
                {
                    if (command[0] == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jaggedArray[row][col] -= value;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine().Split();
            }
            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
