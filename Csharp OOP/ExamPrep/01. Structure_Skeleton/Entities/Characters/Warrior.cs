﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior: Character,IAttacker
    {
        public Warrior(string name)
            : base(name, 100, 50, 40,new Satchel())
        {
             
        }

        public void Attack(Character character)
        {
            EnsureAlive();
             
                  if (character.Name == Name)
                  {
                    throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
                  }
                  character.TakeDamage(AbilityPoints);
            
        }
    }
}
