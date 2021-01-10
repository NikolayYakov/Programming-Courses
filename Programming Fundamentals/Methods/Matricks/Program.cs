using System;

namespace Matricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Matricks(number);
        }
        static void Matricks(int number)
        {
            string text = string.Empty;
            for(int i=1;i<=number;i++)
            {
                             
                for(int k = 1; k <= number; k++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
