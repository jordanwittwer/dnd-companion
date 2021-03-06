﻿using System;
using System.Collections.Generic;

namespace dnd_companion.Model
{
    public class Character
    {
        public Character()
        {
            Level = 1;
            HP = 100;
            PP = 100;
        }

        public string Name  { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

        public int Level { get; set; }

        public int Experience { get; set; }

        public int Strength { get; set; }

        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }

        public int HP { get; set; }

        public int MaxHP { get; set; }

        public int PP { get; set; }

        public int Initiative { get; set; }

        public int Speed { get; set; }

        public string HitDice { get; set; }

        public List<Attack> Attacks { get; set; }

        public void Attack(Character character)
        {
            var attack = Attacks[0];
            this.PP = PP - attack.Cost;
            character.HP = character.HP - attack.Damage;
        }

        public void ListAttacks()
        {
            foreach(var attack in Attacks)
            {
                Console.WriteLine($"{attack.Name} | Cost: {attack.Cost} | Dmg: {attack.Damage}");
            }
        }
    }
}
