using System;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInterval = int.Parse(Console.ReadLine());
            int secondInterval = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            bool flag = false;
            int i = 0;
            int j = 0;
            
            int fullCounter = 0;
            for( i = firstInterval; i <= secondInterval; i++)
            {
                for( j = firstInterval; j <= secondInterval; j++)
                {
                    fullCounter++;
                    
                    if (i + j == sum)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine($"Combination N:{fullCounter} ({i} + {j} = {sum})");
               
            }
            else
            {
                Console.WriteLine($"{fullCounter} combinations - neither equals {sum}");
            }
        }
    }
}
