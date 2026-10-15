using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace orisha_realms
{
    public class Yemoja : Character
    {
        public Yemoja() : base("Yemoja", "Water Guardian", 100, 85, 65, 70, 95, 75) { }

        public override void Act()
        {
            Console.WriteLine(Name + " calls upon the power of water.");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: May the waters bring protection.");
        }
    }
}
