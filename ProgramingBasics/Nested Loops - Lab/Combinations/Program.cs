using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 0;
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= number;i++)
            {
                for(int k = 0; k <= number; k++)
                {
                    for(int j = 0; j <= number; j++)
                    {
                        sum = i + k + j;
                        if (sum == number)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
         
        }
    }
}
