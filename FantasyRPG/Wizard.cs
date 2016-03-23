using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Wizard : CharacterClass
 {

        public Wizard()
        {
            className = "Wizard";
            strengthStart = 5;
            strengthOnLevel = 1;
            constitutionStart = 15;
            constitutionOnLevel = 3;
            dexterityStart = 5;
            dexterityOnLevel = 1;
            intelligenceStart = 20;
            intelligenceOnLevel = 4;
            pietyStart = 15;
            pietyOnLevel = 3;
        }
    }
}
