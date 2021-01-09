using System;
using System.Linq;
namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
            double leftSum = 0;
            double rightSum = 0;
             
            
            bool flag = false;
            for( int i = 0; i < arr.Length; i++)
            {
                 leftSum = 0.0;
                 rightSum = 0.0;

                for( int k = 0; k < arr.Length; k++)
                {
                    if (arr.Length==1)
                    {
                        leftSum = rightSum;
                        break;
                    }
                    if (i == 0)
                    {
                        leftSum = 0;
                        if (k >= 1)
                        {
                            rightSum += arr[k];
                        }
                    }
                    if (i == arr.Length-1)
                    {
                        rightSum = 0;
                        if (k < arr.Length - 1)
                        {
                            leftSum += arr[k];
                        }
                    }
                    else
                    {
                        if (k < i)
                        {
                            leftSum += arr[k];

                        }
                        else if (k > i)
                        {
                            rightSum += arr[k];
                        }
                    }
                    
                   
                }
                if (leftSum == rightSum)
                {
                    flag = true;
                    Console.WriteLine(i);
                    break;
                }
                 

            }
            if (flag==false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
