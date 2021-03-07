using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heros = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BaseHero hero = null;
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                if(type == "Paladin")
                {
                    hero = new Paladin(name);
                }
                else if(type == "Druid")
                {
                    hero = new Druid(name);
                }
                else if(type == "Rogue")
                {
                    hero = new Rogue(name);
                }
                else if(type == "Warrior")
                {
                    hero = new Warrior(name);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
                if (hero != null)
                {
                    heros.Add(hero);
                }
            }
            int power = 0;
            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in heros)
            {
                power += hero.Power;
               Console.WriteLine(hero.CastAbility());
            }
            if (power >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
