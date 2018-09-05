using System;
namespace dnd_companion.Model
{
    public class Character
    {
        public Character()
        {
            Level = 1;
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


    }
}
