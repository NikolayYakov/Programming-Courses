using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Character> characterParty;
		private List<Item> itemPool;
		public WarController()
		{
			characterParty = new List<Character>();
			itemPool = new List<Item>();
		}

		public string JoinParty(string[] args)
		{
			string type = args[0];
			string name = args[1];
			Character character;
            if (type == "Warrior")
            {
				character = new Warrior(name);
            }
			else if (type == "Priest")
            {
				character = new Priest(name);
            }
            else
            {
				throw new ArgumentException($"Invalid character type \"{type}\"!");

			}
			characterParty.Add(character);
			return $"{name} joined the party!";

		}

		public string AddItemToPool(string[] args)
		{
			string name = args[0];
			Item item;
            if (name == "FirePotion")
            {
				item = new FirePotion();
            }
			else if (name == "HealthPotion")
            {
				item = new HealthPotion();
            }
            else
            {
				throw new ArgumentException($"Invalid item \"{name}\"!");

            }
			itemPool.Add(item);
			return $"{name} added to pool.";
		}

		public string PickUpItem(string[] args)
		{
			string charName = args[0];
			Character character = characterParty.FirstOrDefault(c => c.Name == charName);
            if (character == null)
            {
				throw new ArgumentException($"Character {charName} not found!");

			}
            else
            {
                if (itemPool.Count == 0)
                {
					throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);

				}
                else
                {
					Item item = itemPool[itemPool.Count - 1];
					character.Bag.AddItem(itemPool[itemPool.Count - 1]);
					itemPool.RemoveAt(itemPool.Count - 1);
					return $"{charName} picked up {item.GetType().Name}!";

				}
			}
		}

		public string UseItem(string[] args)
		{
			string charName = args[0];
			string itemName = args[1];
			Character character = characterParty.FirstOrDefault(c => c.Name == charName);
			if (character == null)
			{
				throw new ArgumentException($"Character {charName} not found!");

			}
			Item item = character.Bag.GetItem(itemName);
			character.UseItem(item);
			return $"{charName} used {itemName}.";
		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();
            foreach (var hero in characterParty.OrderByDescending(c=>c.IsAlive).ThenByDescending(c=>c.Health))
            {
                if (hero.IsAlive == true)
                {
					sb.AppendLine($"{hero.Name} - HP: {hero.Health}/{hero.BaseHealth}, AP: {hero.Armor}/{hero.BaseArmor}, Status: Alive");

				}
                else
                {
					sb.AppendLine($"{hero.Name} - HP: {hero.Health}/{hero.BaseHealth}, AP: {hero.Armor}/{hero.BaseArmor}, Status: Dead");

				}
				
            }
			return sb.ToString().Trim();
		}

		public string Attack(string[] args)
		{
			string attName = args[0];
			string deffName = args[1];
			Character att = characterParty.FirstOrDefault(c => c.Name == attName);
            if (att == null)
            {
				throw new ArgumentException($"Character {attName} not found!");

			}
			Character deff = characterParty.FirstOrDefault(c => c.Name == deffName);
			if (deff == null)
			{
				throw new ArgumentException($"Character {deffName} not found!");

			}
			if(!(att is Warrior))
            {
				throw new ArgumentException($"{attName} cannot attack!");

			}
            else
            {
				((Warrior)att).Attack(deff);
				StringBuilder sb = new StringBuilder();
			    sb.AppendLine($"{attName} attacks {deffName} for {att.AbilityPoints} hit points! {deffName} has {deff.Health}/{deff.BaseHealth} HP and {deff.Armor}/{deff.BaseArmor} AP left!");

				if (deff.Health <= 0)
                {
					sb.AppendLine($"{deff.Name} is dead!");
                }
				return sb.ToString().Trim();
            }

		}

		public string Heal(string[] args)
		{
			string healer = args[0];
			string healingReceiverName = args[1];
			Character heal = characterParty.FirstOrDefault(c => c.Name == healer);
			if (heal == null)
			{
				throw new ArgumentException($"Character {healer} not found!");

			}
			Character healed = characterParty.FirstOrDefault(c => c.Name == healingReceiverName);
			if (healed == null)
			{
				throw new ArgumentException($"Character {healingReceiverName} not found!");

			}
			if (!(heal is Priest))
			{
				throw new ArgumentException($"{heal.Name} cannot heal!");

			}
            else
            {
				((Priest)heal).Heal(healed);
				return $"{heal.Name} heals {healed.Name} for {heal.AbilityPoints}! {healed.Name} has {healed.Health} health now!";
            }
		}
	}
}
