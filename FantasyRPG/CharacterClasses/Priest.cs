using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Priest : CharacterClass
    {
        public Priest()
        {
            className = "Priest";
            strengthStart = 5;
            strengthOnLevel = 1;
            constitutionStart = 15;
            constitutionOnLevel = 3;
            dexterityStart = 5;
            dexterityOnLevel = 1;
            intelligenceStart = 15;
            intelligenceOnLevel = 3;
            pietyStart = 20;
            pietyOnLevel = 4;
            KnownSkillList.Add("Cure");
            KnownSkillList.Add("Bless");
            KnownSkillList.Add("Cleanse");
            KnownSkillList.Add("Protect");
            KnownSkillList.Add("Holy");
            KnownSkillList.Add("Pray");

        }
    }
}
