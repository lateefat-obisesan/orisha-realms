using Artifact_Legacy_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms.Legacy
{
    public class SplorgAdapter : Character
    {
        private readonly Splorg _splorg;
        private readonly string _displayColor;
        public SplorgAdapter(string name, string color) : base(name, color + " Splorg", 50, 50, 50, 50, 50, 50)
        {
            switch ()
            {
                case "red":
                    _displayColor = "Red";
                    break;

                case "green":
                    _displayColor = "Green";
                    break;

                case "blue":
                    _displayColor = "Blue";
                    break;
                default:
                    throw new ArgumentException("Choose Red, Green or Blue.", nameof(color));
            }
            _splorg = new Splorg(name, _displayColor);
            Lineage = _displayColor + "Splorg";

            Health = _splorg.BubbleDurability * 10;
            Defense = (int)(_splorg.BubbleMatterRemaining * 100);
            Speed = _splorg.Speed * 10;
            Strength = (_splorg.BubbleDurability + _splorg.Luck) * 5;
            Intellect = _splorg.Smarts * 10;
            Agility = (_splorg.Finesse + _splorg.Luck) * 5;

        }
        public override void Act()
        {
            _displayColor.SplorgAction();
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: " + _splorg.Communicate())
        }
    }
}
