using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int i =1;i<=n;i++)
            {
                int realNumber = i;
                int digit = i ;
                int sum = 0;
                while (i > 0)
                {
                    digit = i % 10;
                    sum += digit;
                    i = i / 10;
                  
                    
                    

                }
                if (sum==5||sum==7||sum==11)
                {
                    Console.WriteLine($"{realNumber} -> True");
                }
                else
                {
                    Console.WriteLine($"{realNumber} -> False");
                }
                i = realNumber;
           
                
            }
 
        }
    }
}
