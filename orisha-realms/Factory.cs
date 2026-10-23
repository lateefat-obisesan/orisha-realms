using orisha_realms.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
    public class Factory
    {
        public static Character CreateCharacter(string choice, string name string color = "")
        {
            switch (choice.ToLower())
            {
                case "ogun":
                    Ogun ogun = new Ogun();
                    ogun.Name = name;
                    return ogun;
                case "eshu":
                    Esu eshu = new Esu();
                    eshu.Name = name;
                    return eshu;
                case "yemoja":
                    Yemoja yemoja = new Yemoja();
                    yemoja.Name = name;
                    return yemoja;
                case "splorg":
                    return new SplorgAdapter(name, color);
                default:
                    Ogun error = new Ogun();
                   error.Name = name;
                    return error;
            }
        }
    }
}
