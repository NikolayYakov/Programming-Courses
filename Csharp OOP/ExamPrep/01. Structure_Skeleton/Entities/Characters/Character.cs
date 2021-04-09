using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            BaseHealth = health;
            BaseArmor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
            Health = BaseHealth;
            Armor = BaseArmor;
        }
		public bool IsAlive { get; set; } = true;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                name = value;
            }

        }
        public double BaseHealth  { get;private set; }
        public double Health  { get; set; }
        public double BaseArmor  { get;private set; }
        public double Armor { get; set; }
        public double AbilityPoints  { get; set; }
        public Bag Bag { get; set; }
        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
        public void TakeDamage(double hitPoints)
        {
            EnsureAlive();
           
            
                double armorOriginal = Armor;
                Armor -= hitPoints;
                hitPoints -= armorOriginal;
                if (Armor < 0)
                {
                    Armor = 0;
                }
                if (hitPoints > 0)
                {
                    Health -= hitPoints;
                    if (Health <= 0)
                    {
                        IsAlive = false;
                        Health = 0;
                    }
                }
            
        }
        public void  UseItem(Item item)
        {
            EnsureAlive();
            item.AffectCharacter(this);
            
        }

    }
}