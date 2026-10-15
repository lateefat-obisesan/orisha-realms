using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
   public class WaterPower : CharacterPower
    {
        public WaterPower(Character character) : base(character)
        {
            Health += 25;
        }

        public override void Act()
        {
            base.Act();
            Console.WriteLine($"{Name} summons flowing water currents!");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine($"{Name} whispers: Water heals and protects.");
        }
    }
}
