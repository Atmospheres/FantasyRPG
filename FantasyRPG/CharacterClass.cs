using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class CharacterClass
    {
        public List<string> KnownSkillList = new List<string>();
        public string className;
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
    }
}
