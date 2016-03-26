using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class Skill
    {
        public List<string> subSkillList = new List<string>();
        public string subSkillType;
        public string skillCanTarget;
        public int cursorFourStart;
        public int typeInt;
        public int manaCost;
        public string typeString;
        protected Dice dice = new Dice();


   
        public Skill()
        {
        }
        public virtual double SkillEffect(Character Player)
        {
            double effect = 0;
            return effect;
        }
    }
}
