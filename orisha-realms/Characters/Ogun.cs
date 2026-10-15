using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace orisha_realms
{
    public class Ogun : Character
    {
        public Ogun() : base("Ogun", "Warrior", 100, 90, 55, 100, 60, 65)
        {

        }
        public override void Act()
        {
            Console.WriteLine(Name + " strikes with great strength.");
        }

        public override void Speak()
        {
            Console.WriteLine(Name + " says: I stand strong and protect my people.");
        }
    }
}
