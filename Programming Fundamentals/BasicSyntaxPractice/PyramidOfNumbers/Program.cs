using System;

namespace PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for(int rows = 1; rows <= number; rows++)
            {
                for(int colums = 1; colums <= rows; colums++)
                {
                    Console.Write($"{rows} ");
                    
                }
                Console.WriteLine("");
            }
        }
    }
}
