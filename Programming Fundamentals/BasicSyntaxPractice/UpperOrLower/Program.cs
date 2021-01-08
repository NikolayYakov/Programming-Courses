using System;

namespace UpperOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (Char.IsUpper(symbol) == true)
            {
                Console.WriteLine("upper-case");
                
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
