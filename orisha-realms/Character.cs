using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
    public class Character
    {
        public string Name { get; set; }
        public string Lineage { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Intellect { get; set; }
        public int Agility { get; set; }

        public Character (string name, string lineage, int health, int defense, int speed, int strength, int intellect, int agility)
        {
            Name = name;
            Lineage = lineage;

        }
    }
}
