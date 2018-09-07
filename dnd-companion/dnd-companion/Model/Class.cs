using System;
namespace dnd_companion.Model
{
    public class Class
    {
        public Class()
        {
        }

        public string[] ClassName { get; set; }

        public string Description { get; set; }

        public string HitDie { get; set; }

        public string HitPoint { get; set; }

        public string PrimaryAbility { get; set; }
        
        public string[] SavingThrows { get; set; }

        public string Equipment { get; set; }//includes weapons, armor, clothes, and tools. 

        public string[] Skills { get; set; }
    }
}
