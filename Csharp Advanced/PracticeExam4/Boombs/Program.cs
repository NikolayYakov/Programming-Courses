using System;
using System.Collections.Generic;
using System.Linq;

namespace Boombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombsEffects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombsCases = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> bombsEffectsQueue = new Queue<int>(bombsEffects);
            Stack<int> bombsCasesStack = new Stack<int>(bombsCases);
            int datureBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;
            while (Math.Min(bombsEffectsQueue.Count, bombsCasesStack.Count) > 0)
            {
                int bombEffect = bombsEffectsQueue.Peek();
                int bombCase = bombsCasesStack.Peek();
                int sum = bombEffect + bombCase;
                if (sum == 40)
                {
                    datureBombs++;
                    bombsEffectsQueue.Dequeue();
                    bombsCasesStack.Pop();
                }
                else if (sum == 60)
                {
                    cherryBombs++;
                    bombsEffectsQueue.Dequeue();
                    bombsCasesStack.Pop();
                }
                else if (sum == 120)
                {
                    smokeDecoyBombs++;
                    bombsEffectsQueue.Dequeue();
                    bombsCasesStack.Pop();
                }
                else
                {
                    bombCase -= 5;
                    bombsCasesStack.Pop();
                    bombsCasesStack.Push(bombCase);
                }
                if (datureBombs > 2 && cherryBombs > 2 & smokeDecoyBombs > 2)
                {
                    break;
                }
            }
            if (datureBombs > 2 && cherryBombs > 2 && smokeDecoyBombs > 2)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombsEffectsQueue.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombsEffectsQueue)}");

            }
            if (bombsCasesStack.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombsCasesStack)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {datureBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
