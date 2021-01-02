using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumbers = int.Parse(Console.ReadLine());
            randomNumbers *= 2;
            int rightSum = 0;
            int leftSum = 0;
            for (int i = 0; i < randomNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i < randomNumbers / 2)
                {
                    rightSum += number;
                }
                else
                {
                    leftSum += number;
                }
            }
            if (rightSum == leftSum)
            {
                 

                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int difference = rightSum - leftSum;
                Console.WriteLine($"No, diff = {Math.Abs(difference)}");
            }
        }
    }
}
