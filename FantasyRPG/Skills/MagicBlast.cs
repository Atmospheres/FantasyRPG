using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class MagicBlast : Skill
    {
        int damage;
        public MagicBlast()
        {
            skillCanTarget = "AnyTeam";
            cursorFourStart = 10;
            subSkillType = "Element:";
            subSkillList.Add("Fire");
            subSkillList.Add("Ice");
            subSkillList.Add("Wind");
            subSkillList.Add("Earth");
            subSkillList.Add("Lightning");
            subSkillList.Add("Water");
            manaCost = 10;
        }
        public override double SkillEffect(Character Player)
        {
            typeInt = FightScreen.cursorSectionThree;
            damage = dice.DFour() + (Player.intelligence / 5);
            return damage;
        }
    }
}
