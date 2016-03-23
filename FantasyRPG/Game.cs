using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Game
    {
        Party mainParty = new Party();
        Party enemyParty = new Party();
        Battle battle = new Battle();
        Screen screen = new Screen();
        
        public void StartGame()
        {
            mainParty.SetupParty();
            enemyParty.SetupParty();
            screen.PolulateMainPartyInfo(mainParty);
            //    battle.BattleSetup(mainParty, enemyParty);
            //   screen.PassBattleInfo(mainParty, enemyParty);
            screen.fightScreen.PopulateFightScreen(screen.screenTemplate);
            screen.fightScreen.AddEnemyInfo(enemyParty);
            screen.fightScreen.PopulateSubNames(mainParty);
            screen.fightScreen.PrintFightScreen();
            
        }
    }
}
