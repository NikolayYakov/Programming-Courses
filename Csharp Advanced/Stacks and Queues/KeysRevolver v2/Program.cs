using System;
using System.Collections.Generic;
using System.Linq;

namespace KeysRevolver_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int bulletBarrel = int.Parse(Console.ReadLine());
            int bulletFired = 0;
            int[] bullets = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int[] locks = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
            int inteligenceValue = int.Parse(Console.ReadLine());
            int bulletCount = 0;
            while (bulletsStack.Count > 0 && locksQueue.Count > 0)
            {
              
                int bullet = bulletsStack.Pop();
                bulletCount++;
                bulletFired++;
                int currentLock = locksQueue.Peek();
                if (currentLock >= bullet)
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletBarrel == bulletFired&&bulletsStack.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    bulletFired = 0;
                }
            }
            if (locksQueue.Count == 0)
            {
                int price = inteligenceValue - bulletCount * bulletPrice;
                int bulletLeft = bullets.Length - bulletCount;
                Console.WriteLine($"{bulletLeft} bullets left. Earned ${price}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
