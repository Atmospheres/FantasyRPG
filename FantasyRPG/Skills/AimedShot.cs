using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class AimedShot : Skill

    {
        public AimedShot()
        {
            skillType = "Attack";
            skillCanTarget = "Enemy";
            cursorFourStart = 5;
            manaCost = 5;
            typeInt = 0;
            subSkillType = "None";
        }
        public override Party SkillEffect(Party MainParty, Party EnemyParty, int PlayerIndex)
        {
            double damage = 0;
            typeInt = FightScreen.cursorSectionThree;
            if (FightScreen.playerturn == true)
            {
                damage = dice.DTen() + (MainParty.characterList[PlayerIndex].dexterity / 5);
                MainParty.characterList[PlayerIndex].DecreaseMana(manaCost);
            }
            else if (FightScreen.playerturn == false)
            {
                damage = dice.DTen() + (EnemyParty.characterList[PlayerIndex].dexterity / 5);
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

