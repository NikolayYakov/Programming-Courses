using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number0ne = 1;
            while (number0ne<=number)
            {
                Console.WriteLine(number0ne);
                number0ne = number0ne * 2 + 1;
                 
            }
        }
    }
}
