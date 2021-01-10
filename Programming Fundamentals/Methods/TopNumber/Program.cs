using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopInt(number);
        }
        static void TopInt(int number)
        {
            for (int i = 10; i < number; i++)
            {
                bool isOdd = false;
                int sum = 0;
                int old = i;
                while (i != 0)
                {
                   
                    sum += i % 10;
                    int curr = i % 10;
                    if (curr % 2 != 0)
                    {
                        isOdd = true;
                    }
                    i /= 10;
                }
                if (sum % 8 == 0 && isOdd == true)
                {
                    Console.WriteLine(old);
                }
                i = old;

            }
        }
    }
}
