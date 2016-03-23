using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Battle
    {
        Party mainParty = new Party();
        Party enemyParty = new Party();
        public Battle()
        { 
        }

        public void BattleSetup(Party MainParty, Party EnemyParty)
        {
            mainParty = MainParty;
            enemyParty = EnemyParty;
            mainParty.SetupParty();
            enemyParty.SetupParty();

        }
       
    }
}
