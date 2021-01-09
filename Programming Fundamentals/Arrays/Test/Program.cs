using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            a = b;
            b = a;
            Console.WriteLine($"{a} {b}");
        }
    }
}
