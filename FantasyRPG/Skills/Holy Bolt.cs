using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class HolyBolt : Skill
    {
        public HolyBolt ()
        { 
            skillCanTarget = "Any";
            cursorFourStart = 5;
            manaCost = 5;
            subSkillType = "None";
            typeInt = 7;
        }
        public override Party SkillEffect(Party MainParty, Party EnemyParty, int PlayerIndex)
        {
            double damage = 0;
            
            if (FightScreen.playerturn == true)
            {
                damage = dice.DEight() + (MainParty.characterList[PlayerIndex].intelligence / 5);
                MainParty.characterList[PlayerIndex].DecreaseMana(manaCost);
            }
            else if (FightScreen.playerturn == false)
            {
                damage = dice.DEight() + (EnemyParty.characterList[PlayerIndex].intelligence / 5);
                EnemyParty.characterList[PlayerIndex].DecreaseMana(manaCost);
            }
            if (FightScreen.cursorSectionFour < 5)
            {
                MainParty.characterList[FightScreen.cursorSectionFour - 1].RecieveAttack(damage, typeInt);
            }
            else if (FightScreen.cursorSectionFour > 4)
            {
                EnemyParty.characterList[FightScreen.cursorSectionFour - 5].RecieveAttack(damage, typeInt);
            }
            GroupParties(MainParty, EnemyParty);
            return tempParty;
        }
    }
}