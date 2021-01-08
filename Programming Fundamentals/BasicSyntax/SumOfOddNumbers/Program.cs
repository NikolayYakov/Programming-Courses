using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;
            for(int i = 1 ; i>0; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    counter += 1;
                }
                if (counter == amount)
                {
                    break;
                }
                
                
               
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
