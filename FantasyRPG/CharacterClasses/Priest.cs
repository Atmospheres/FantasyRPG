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
            skillNameToList = "Cure";
            skillToList = new Cure();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Bless";
            skillToList = new Bless();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Cleanse";
            skillToList = new Cleanse();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Protect";
            skillToList = new Protect();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "HolyBolt";
            skillToList = new HolyBolt();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "holyNova";
            skillToList = new HolyNova();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Pray";
            skillToList = new Pray();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
        }
    }
}
