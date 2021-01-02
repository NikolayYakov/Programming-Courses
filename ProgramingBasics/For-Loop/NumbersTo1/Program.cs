using System;

namespace NumbersTo1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            for (int number = int.Parse(Console.ReadLine()); number >= 1; number -= 1) 
            {
                Console.WriteLine(number);
            }
        }
    }
}
