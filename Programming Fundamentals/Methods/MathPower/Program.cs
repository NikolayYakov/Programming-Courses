using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
          int resul=  finalNumber(number, power);
            Console.WriteLine(resul);
        }
        static int finalNumber(int number,int power)
        {
            int result = number;
            for(int i = 2; i <= power; i++)
            {
                result = result * number; 
            }
            return result;
        }
    }
}
