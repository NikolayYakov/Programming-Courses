using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            
            for(int n = firstNumber; n <= secondNumber; n++)
            {
                int evenSum = 0;
                int oddSum = 0;
                string curentNumber = n.ToString();

                for(int i = 0; i <curentNumber.Length; i++)
                {
                    int curentDigit = int.Parse(curentNumber[i].ToString());
                    if (i % 2 == 0)
                    {
                        evenSum += curentDigit;
                    }
                    else
                    {
                        oddSum += curentDigit;
                    }

 
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{n} ");
                }
            }
           
        }
    }
}
