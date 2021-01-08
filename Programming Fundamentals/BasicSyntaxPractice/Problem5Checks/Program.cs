using System;

namespace Problem5Checks
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            
            for (int i = 1;i<= number; i++)
{
                digit = i;
                while (digit>0)
{
                    sum += digit % 10;
                    digit = digit / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0;


            }
        }
    }
}
