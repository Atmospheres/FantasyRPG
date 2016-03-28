using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class ExplodingShot : Skill
    {
        int damage;
        public ExplodingShot()
        {
            skillCanTarget = "EnemyTeam";
            cursorFourStart = 10;
            manaCost = 10;
        }
        public override Party SkillEffect(Party MainParty, Party EnemyParty, int PlayerIndex)
        {
            double damage = 0;
            typeInt = 1;
            if (FightScreen.playerturn == true)
            {
                damage = dice.DFour() + (MainParty.characterList[PlayerIndex].dexterity/ 5);
                MainParty.characterList[PlayerIndex].DecreaseMana(manaCost);
            }
            else if (FightScreen.playerturn == false)
            {
                damage = dice.DFour() + (EnemyParty.characterList[PlayerIndex].dexterity / 5);
                EnemyParty.characterList[PlayerIndex].DecreaseMana(manaCost);
            }
            if (FightScreen.cursorSectionFour == 9)
            {
                for (int i = 0; i < MainParty.characterList.Count(); i++)
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
