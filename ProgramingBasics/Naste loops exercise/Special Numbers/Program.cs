using System;

namespace Special_nUMBERS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int n = 1111; n <= 9999; n++)
            {
                string specialNumber = n.ToString();
                for (int i = 0; i < specialNumber.Length; i++)
                {
                    int curentDigit = int.Parse(specialNumber[i].ToString());
                    if (curentDigit == 0)
                    {
                        break;
                    }
                    if (number % curentDigit == 0)
                    {
                        counter++;
                    }
                    if (counter == 4)
                    {
                        Console.Write($"{n} ");
                    }
                }
                counter = 0;
            }
        }
    }
}
