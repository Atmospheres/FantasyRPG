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
            skillNameToList = "Stance";
            skillToList = new Stance();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Cyclone";
            skillToList = new Cyclone();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Bash";
            skillToList = new Bash();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Guard";
            skillToList = new Guard();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Bandage";
            skillToList = new Bandage();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Charge";
            skillToList = new Charge();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
        }
    }
}
