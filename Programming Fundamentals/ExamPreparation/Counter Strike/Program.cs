using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            string distance = Console.ReadLine();
            bool flag = true;
            while(distance!= "End of battle")
            {
                int diff = 0;
                int realDistance = int.Parse(distance);
                diff = energy - realDistance;

                if (diff>=0)
                {
                    energy -= realDistance;
                    wins += 1;
                }
                if (wins % 3 == 0)
                {
                    energy += wins;
                }

                if (diff < 0)
                {
                    flag = false;
                    
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    break;
                }
                
                distance = Console.ReadLine();
            }
            if (flag == true)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
