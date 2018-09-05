using System;
using dnd_companion.Model;

namespace dnd_companion
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();

            Console.Write("Character name: ");
            character.Name = Console.ReadLine();

            Console.Write("Character Race: ");
            character.Race = Console.ReadLine();

            Console.Write("Character Class: ");
            character.Class = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Selected Name: " + character.Name);
            Console.WriteLine("Selected Race: " + character.Race);
            Console.WriteLine("Selected Class: " + character.Class);
            Console.WriteLine("Charcter Level: " + character.Level);

        }
    }
}
