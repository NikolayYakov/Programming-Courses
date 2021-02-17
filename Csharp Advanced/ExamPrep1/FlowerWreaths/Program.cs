using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] roses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> liliesStack = new Stack<int>(lilies);
            Queue<int> rosesQueue = new Queue<int>(roses);
            int wreaths = 0;
            int left = 0;
            while (Math.Min(liliesStack.Count, rosesQueue.Count) > 0)
            {
                int lili = liliesStack.Peek();
                int rose = rosesQueue.Peek();
                if (lili + rose == 15)
                {
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                    wreaths++;
                }
                else if (lili + rose < 15)
                {
                    liliesStack.Pop();
                    rosesQueue.Dequeue();
                    left += lili + rose;
                }
                else
                {
                    liliesStack.Pop();
                    lili -= 2;
                    if (lili > 0)
                    {
                        liliesStack.Push(lili);
                    }
                    
                }
                
            }
            wreaths += (int)Math.Floor(left / 15.0);
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
            

        }
    }
}
