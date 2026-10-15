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
    }
}
