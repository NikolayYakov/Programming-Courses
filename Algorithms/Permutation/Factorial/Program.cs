using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        static int Factorial(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
