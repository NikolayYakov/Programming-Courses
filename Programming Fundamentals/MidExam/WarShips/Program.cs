using System;
using System.Data;
using System.Linq;

namespace WarShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                                      .Split(">", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();
            int[] warShip = Console.ReadLine()
                                   .Split(">", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            int maxHealth = int.Parse(Console.ReadLine());
            string[] commmand = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool PirateShipSink = false;
            bool WarShipSink = false;
            while(commmand[0]!= "Retire")
            {
                switch (commmand[0])
                {
                    case "Fire":
                        int index = int.Parse(commmand[1]);
                        int damage = int.Parse(commmand[2]);
                        Fire(warShip, index, damage);
                     
                        break;
                    case "Defend":
                        int startIndex = int.Parse(commmand[1]);
                        int endIndex = int.Parse(commmand[2]);
                        int PirateShipDamage = int.Parse(commmand[3]);
                        Defend(pirateShip, startIndex, endIndex, PirateShipDamage);
                        
                           
                        break;
                    case "Repair":
                        int indexRepair = int.Parse(commmand[1]);
                        int health = int.Parse(commmand[2]);
                        Repair(pirateShip, indexRepair, health, maxHealth);
                        break;
                    case "Status":
                        int needRepair = Status(pirateShip, maxHealth);
                        Console.WriteLine($"{needRepair} sections need repair.");
                        break;
                    
                }
                commmand = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            for(int i = 0; i < pirateShip.Length; i++)
            {
                if (pirateShip[i] == 0)
                {
                    PirateShipSink = true;
                }
            }
            for(int i = 0; i < warShip.Length; i++)
            {
                if (warShip[i] == 0)
                {
                    WarShipSink = true;
                }
            }
            if (WarShipSink == false && PirateShipSink == false)
            {
                int warShipSum = 0;
                int pirateShipSum = 0;
                for(int i = 0; i < pirateShip.Length; i++)
                {
                    pirateShipSum += pirateShip[i];
                     
                }
                for(int i = 0; i < warShip.Length; i++)
                {
                    warShipSum += warShip[i];
                }
                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warShipSum}");
            }
            else
            {
                for (int i = 0; i < pirateShip.Length; i++)
                {
                    if (pirateShip[i] == 0)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        break;
                    }
                }
                for (int i = 0; i < warShip.Length; i++)
                {
                    if (warShip[i] == 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        break;
                    }
                }
            }
           

        }
        static void Fire(int[] warShip,int index,int damage )
        {
            if (index > -1 && index < warShip.Length)
            {
                warShip[index] -= damage;   
            }
        }
        static void Defend(int[] pirateShip,int starIndex,int endIndex,int damage)
        {
            if (starIndex > -1 && starIndex < pirateShip.Length && endIndex > -1 && endIndex < pirateShip.Length)
            {
                 for(int i = starIndex; i <= endIndex; i++)
                 {
                    pirateShip[i] -= damage;
                    if (pirateShip[i] <= 0)
                    {
                        pirateShip[i] = 0;
                    }
                 }
            }
        }
        static void Repair(int[] pirateShip,int index,int health,int maxHealth)
        {
            if (index > -1 && index < pirateShip.Length)
            {
                if (pirateShip[index] + health < maxHealth)
                {
                    pirateShip[index] += health;
                }
            }
        }
        static int Status(int[] pirateShip,int maxHealth)
        {
            int needRepair = 0;
            foreach (int sections in pirateShip)
            {
                double max = Math.Round(maxHealth * 0.20);
                if (sections < max)
                {
                    needRepair++;
                }
            }
            return needRepair;
        }
    }
}
