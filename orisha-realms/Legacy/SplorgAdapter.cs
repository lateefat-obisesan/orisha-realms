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
        private readonly Splorg _splog;
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
                    throe new ArgumentException("Choose Red, Green or Blue.", nameof(color));
            }

        }
    }
}
