using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenOrOdd = number % 2;
            bool finalCheck = evenOrOdd == 0;
            if (finalCheck == true)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
