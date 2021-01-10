using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        static void PrintLine(int start,int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int line)
        {
            for(int i = 1; i <= line; i++)
            {
                PrintLine(1,i);
            }
            for(int k = line-1; k >= 1; k--)
            {
                PrintLine(1,k);
            }
        }

    }
}
