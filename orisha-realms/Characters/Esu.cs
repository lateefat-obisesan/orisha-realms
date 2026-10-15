using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
    public class Esu : Character
    {
        public Esu() : base("Esu","Trickster", 80, 55, 100, 65, 90, 100)
        {

        }
        public override void Act()
        {
            Console.WriteLine(Name + "moves quickly and confuses opponents.");
        }
        public override void Speak()
        {
            Console.WriteLine(Name + "says: Every path holds a choice.");
        }
    }
}
