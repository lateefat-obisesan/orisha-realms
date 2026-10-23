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
        public SplorgAdapter(string name, string color) : base(name, color + " Splorg", 50, 50, 50, 50, 50, 50)
        {
            _splorg = new Splorg(name, "Red");
        }
    }
}
