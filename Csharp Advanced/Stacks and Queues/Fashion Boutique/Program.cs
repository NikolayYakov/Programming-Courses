using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();
            int rack = int.Parse(Console.ReadLine());
            int rackValue = rack;
            int count = 1;
            int clothValue = 0;
            Stack<int> clothesStack = new Stack<int>(clothes);
            while (clothesStack.Count > 0)
            {
                int cloth = clothesStack.Pop();
                clothValue += cloth;
                if (rack==clothValue)
                {             
                    if (clothesStack.Count > 0)
                    {
                        clothValue = 0;
                        count++;
                    }
                   
                }
                else if (clothValue > rack)
                {
                    clothValue = cloth;
                    count++;
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
