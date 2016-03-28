using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class Skill
    {
        public Party tempParty = new Party();
        public List<string> subSkillList = new List<string>();
        public string subSkillType;
        public string skillType;
        public string skillCanTarget;
        public int cursorFourStart;
        public int typeInt;
        public int manaCost;

        protected Dice dice = new Dice();


        // need to rebuild skills to take in both parties and return them as one list to battle to be split and reassigned.
        public Skill()
        {
        }
        public virtual Party SkillEffect(Party MainParty, Party EnemyParty, int PlayerIndex)
        {

            GroupParties(MainParty, EnemyParty);
            return tempParty;
        }
        public virtual void GroupParties(Party MainParty, Party EnemyParty)
        {

            for (int i = 0; i < 4; i++)
            {
                tempParty.characterList.Add(MainParty.characterList[i]);
               
            }
            for (int i = 0; i < EnemyParty.characterList.Count(); i++)
            {
                tempParty.characterList.Add(EnemyParty.characterList[i]);
            }
        }
    }
}
