using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            bool greaterNumber = numberA > numberB;
            if(greaterNumber == true)
            {
                Console.WriteLine(numberA);
            }
            else
            {
                Console.WriteLine(numberB);
            }
        }
    }
}
