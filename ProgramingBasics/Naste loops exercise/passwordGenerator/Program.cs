using System;

namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            
            for(int number1 = 1; number1 <= n; number1++)
            {
                for(int number2 = 1; number2 <= n; number2++) 
                {

                    for(char alpha = 'a'; alpha <'a'+l ; alpha++)
                    {
                       
                        for(char betta = 'a'; betta < 'a'+l; betta++)
                        {
                            
                            for (int finalNumber = 1; finalNumber <= n; finalNumber++)
                            {
                                    if(finalNumber > number1 && finalNumber > number2)
                                    {
                                    Console.Write($"{number1}{number2}{alpha}{betta}{finalNumber} ");
                                    }
                            }

                        }
                        
                    }
                }
            }
        }
    }
}
