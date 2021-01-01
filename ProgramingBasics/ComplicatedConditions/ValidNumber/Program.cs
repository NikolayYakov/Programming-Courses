using System;

namespace ValidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                if (number != 0)
                {
                    Console.WriteLine("invalid");
                }
            }
            if (number > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
