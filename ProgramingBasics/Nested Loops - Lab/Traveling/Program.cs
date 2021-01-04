using System;
using System.Diagnostics.CodeAnalysis;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                string destination = Console.ReadLine();
                
                if (destination == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double money = 0.0;
                while (money < budget )
                {
                    double income = double.Parse(Console.ReadLine());
                    money += income;
                }
                Console.WriteLine($"Going to {destination}!");
                 
                 
             
                 
                

            }
        }
    }
}
