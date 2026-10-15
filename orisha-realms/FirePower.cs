using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
   public class FirePower : CharacterPower
   {
        public FirePower(Character character) : base(character)
        {
            Strength += 20;
        }

        public override void Act()
        {
            base.Act();
            Console.WriteLine($"{Name} uses fire attack.");
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine($"{Name} whispers: The flames guide my path");
        }
   }
}
