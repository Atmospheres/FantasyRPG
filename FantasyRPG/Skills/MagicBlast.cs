using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class MagicBlast : Skill
    {
        
        public MagicBlast()
        {
            skillType = "Attack";
            skillCanTarget = "Team";
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
        public override Party SkillEffect(Party MainParty, Party EnemyParty, int PlayerIndex)
        {
            double damage = 0;
            typeInt = FightScreen.cursorSectionThree;
            if (FightScreen.playerturn == true)
            {
                damage = dice.DFour() + (MainParty.characterList[PlayerIndex].intelligence / 5);
                MainParty.characterList[PlayerIndex].DecreaseMana(manaCost); 
            }
            else if(FightScreen.playerturn == false)
            {
                damage = dice.DFour() + (EnemyParty.characterList[PlayerIndex].intelligence / 5);
                EnemyParty.characterList[PlayerIndex].DecreaseMana(manaCost);
            }
            if(FightScreen.cursorSectionFour == 9)
            {
                for(int i = 0; i < MainParty.characterList.Count(); i++)
                {
                    MainParty.characterList[i].RecieveAttack(damage, typeInt);
                }
            }
            else if (FightScreen.cursorSectionFour == 10)
            {
                for (int i = 0; i < MainParty.characterList.Count(); i++)
                {
                    EnemyParty.characterList[i].RecieveAttack(damage, typeInt);
                }
            }
            GroupParties(MainParty, EnemyParty);
            return tempParty;
        }
    }
}
