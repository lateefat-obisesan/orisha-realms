using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
   public abstract class CharacterPower : Character
    {
        protected Character _character;

        public CharacterPower(Character character) : base(character.Name, character.Lineage, character.Health, character.Defense, character.Speed, character.Strength, character.Intellect, character.Agility)
        {
            _character = character;
        }
        public override void Act() => _character.Act();
        public override void Speak() => _character.Speak();
    }
}
