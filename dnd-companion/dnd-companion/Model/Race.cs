using System;
namespace dnd_companion.Model
{
    public class Race
    {
        public Race()
        {
        }

        public string[] RaceName { get; set; }
        public string AbilityScoreIncrease { get; set; }

        public int Age { get; set; }

        public string Alignment { get; set; }

        public string Size { get; set; }

        public int Speed { get; set; }

        public string[] Abilities { get; set; }

    }
}
