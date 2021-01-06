using System;
using System.ComponentModel;

namespace Subtitution
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberInterval = int.Parse(Console.ReadLine());
            int secondNumberInterval = int.Parse(Console.ReadLine());
            int subtituteFirstNumberInterval = int.Parse(Console.ReadLine());
            int subtituteSecondNumberInterval = int.Parse(Console.ReadLine());
            int counter = 0;
            bool flag = false;
            for(int n = firstNumberInterval; n <=8; n++)
            {
                for(int i = 9; i >= secondNumberInterval; i--)
                {
                    for(int l = subtituteFirstNumberInterval; l <=8; l++)
                    {
                        for(int m = 9; m >= subtituteSecondNumberInterval; m--)
                        {
                            if (n % 2 == 0 && i % 2 != 0 && l % 2 == 0 && m % 2 != 0) 
                            {
                                if (n == l && i == m)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{n}{i} - {l}{m}");
                                    counter++;
                                }
                                if (counter >= 6)
                                {
                                    flag = true;
                                    break;
                                }
                                
                            }
                            
                            
                        }
                        if (flag == true)
                        {
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
                    break;
                }
            }
        }
    }
}
