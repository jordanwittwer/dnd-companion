using System;
using System.Collections.Generic;
using dnd_companion.Model;

namespace dnd_companion
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var monster = new Monster();

            Console.Write("Character Name: ");
            character.Name = Console.ReadLine();
            character.Attacks = new List<Attack>
            {
                new Attack
                {
                    Name = "Jab", Cost = 0, Damage = 10
                },
                new Attack
                {
                    Name = "Thunder Smash", Cost = 20, Damage = 40
                }
            };

            monster.Attacks = new List<Attack>
            {
                new Attack
                {
                    Name = "Scratch", Cost = 0, Damage = 15
                },
                new Attack
                {
                    Name = "Head Butt", Cost = 60, Damage = 50
                }
            };
            while (true)
            {
                character.Attack(monster);
                Console.WriteLine();
                Console.WriteLine("Character HP: " + character.HP);
                Console.WriteLine("Character PP: " + character.PP);
                Console.WriteLine("Monster HP: " + monster.HP);
                Console.WriteLine("Monster PP: " + monster.PP);
                if(monster.HP <= 0)
                {
                    break;
                }
            }
            Console.WriteLine();
          /*  Console.WriteLine("Selected Name: " + character.Name);
            Console.WriteLine("Character Level: " + character.Level);
            Console.WriteLine("Character HP: " + character.HP);
            Console.WriteLine("Character PP: " + character.PP);
            character.ListAttacks();

            Console.WriteLine();
            Console.WriteLine("Selected Name: " + monster.Name);
            Console.WriteLine("Monster Level: " + monster.Level);
            Console.WriteLine("Monster HP: " + monster.HP);
            Console.WriteLine("Monster PP: " + monster.PP); */

        }
    }
}
