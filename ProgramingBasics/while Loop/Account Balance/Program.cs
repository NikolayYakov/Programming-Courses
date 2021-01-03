using System;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;

            string input = Console.ReadLine();
            while (input!= "NoMoreMoney")
            {
                double money = double.Parse(input);
                
                
                if (money >= 0)
                {
                    
                    Console.WriteLine($"Increase: {money:f2}");
                    sum += money;
                    input = Console.ReadLine();
                    
                }
               else if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:f2}");
                    break;
                }
              
                 
                
            }
            if (input == "NoMoreMoney")
            {
                Console.WriteLine($"Total: {sum:f2}");
            }
        }
    }
}
