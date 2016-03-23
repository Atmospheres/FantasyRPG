using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Fighter : CharacterClass
    { 
        public Fighter()
        {
            className = "Fighter";
            strengthStart = 20;
            strengthOnLevel = 4;
            constitutionStart = 20;
            constitutionOnLevel = 4;
            dexterityStart = 10;
            dexterityOnLevel = 2;
            intelligenceStart = 5;
            intelligenceOnLevel = 1;
            pietyStart = 5;
            pietyOnLevel = 1;
        }
    }
}
