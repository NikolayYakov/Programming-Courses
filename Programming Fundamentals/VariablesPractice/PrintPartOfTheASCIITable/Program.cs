using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = begining; i <= end; i++)
            {
                char symbol = (char)i;
                Console.Write($"{symbol} ");
            }
        }
    }
}
