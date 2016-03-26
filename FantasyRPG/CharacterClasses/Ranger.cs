using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Ranger : CharacterClass
    {
        public Ranger()
        {
            className = "Ranger";
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
            skillNameToList = "Aim Shot";
            skillToList = new AimedShot();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Expl. Shot";
            skillToList = new ExplodingShot();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Stun Shot";
            skillToList = new ConcussiveShot();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Stun Barrage";
            skillToList = new ConcussiveBarrage();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Volley";
            skillToList = new Volley();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
            skillNameToList = "Mend Wound";
            skillToList = new MendWound();
            knownSkillList.Add(skillToList);
            skillNames.Add(skillNameToList);
        }
    }
}
