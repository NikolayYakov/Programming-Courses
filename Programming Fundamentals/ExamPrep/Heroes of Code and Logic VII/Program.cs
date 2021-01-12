using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heros = new Dictionary<string, List<int>>(count);
            for(int i = 0; i < count; i++)
            {
                string[] hero = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = hero[0];
                int health = int.Parse(hero[1]);
                int mana = int.Parse(hero[2]);
                heros.Add(name, new List<int>(2));
                heros[name].Add(health);
                heros[name].Add(mana);
            }
            string[] command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "CastSpell":
                        string name = command[1];
                        int manaNeeded = int.Parse(command[2]);
                        string spell = command[3];
                        CastSpell(heros, name, manaNeeded, spell);
                        break;
                    case "TakeDamage":
                        name = command[1];
                        int damage = int.Parse(command[2]);
                        string attacker = command[3];
                        TakeDamage(heros, name, damage, attacker);
                        break;
                    case "Recharge":
                        name = command[1];
                        int amount = int.Parse(command[2]);
                        Recharge(heros, name, amount);
                        break;
                    case "Heal":
                        name = command[1];
                        amount = int.Parse(command[2]);
                        Heal(heros, name, amount);
                        break;
                }
                command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var hero in heros.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
        static void CastSpell(Dictionary<string,List<int>> heros,string name, int manaNeeded,string spell)
        {
            if (manaNeeded <= heros[name][1])
            {
                heros[name][1] -= manaNeeded;
                Console.WriteLine($"{name} has successfully cast {spell} and now has {heros[name][1]} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
            }
        }
        static void TakeDamage(Dictionary<string, List<int>> heros, string name, int damage, string attacker)
        {
            heros[name][0] -= damage;
            if (heros[name][0] > 0)
            {
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heros[name][0]} HP left!");
            }
            else
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                heros.Remove(name);
            }
        }
        static void Recharge(Dictionary<string, List<int>> heros, string name, int amount)
        {
            int pre = heros[name][1];
            heros[name][1] += amount;
            if (heros[name][1] >= 200)
            {
                heros[name][1] = 200;
                int recharched = 200 - pre;
                Console.WriteLine($"{name} recharged for {recharched} MP!");
            }
            else
            {
                Console.WriteLine($"{name} recharged for {amount} MP!");
            }

        }
        static void Heal(Dictionary<string, List<int>> heros, string name, int amount)
        {
            int pre = heros[name][0];
            heros[name][0] += amount;
            if (heros[name][0] >= 100)
            {
                heros[name][0] = 100;
                int healed = 100 - pre;
                Console.WriteLine($"{name} healed for {healed} HP!");
            }
            else
            {
                Console.WriteLine($"{name} healed for {amount} HP!");
            }
        }


    }
}
