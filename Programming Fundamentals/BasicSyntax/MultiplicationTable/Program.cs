using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= 10; i++)
            {
                var sum = 0;
                sum = number * i;
                Console.WriteLine($"{number} X {i} = {sum}");
                
            }
        }
    }
}
