using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class CharacterClass
    {
        public List<Skill> knownSkillList = new List<Skill>();
        public List<string> skillNames = new List<string>();
        public List<string> subSkillList = new List<string>();
        public Skill skillToList = new Skill();
        public string skillNameToList;
        public string skillCanTarget;
        public string className;
        public int skillTargetStart;
        public int strengthStart = 0;
        public int strengthOnLevel = 0;
        public int constitutionStart = 0;
        public int constitutionOnLevel = 0;
        public int dexterityStart = 0;
        public int dexterityOnLevel = 0;
        public int intelligenceStart = 0;
        public int intelligenceOnLevel = 0;
        public int pietyStart = 0;
        public int pietyOnLevel = 0;

        public CharacterClass()
        {

        }

        public void ClearSubSkillList()
        {
            subSkillList.RemoveRange(0, subSkillList.Count());
        }
    }
}
