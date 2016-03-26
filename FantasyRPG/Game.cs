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
            StartBattle();
        }

        public void StartBattle()
        {
            screen.PopulateMainStats(battle.mainParty);
            FightScreen.PopulateFightScreen(screen.screenTemplate);
            FightScreen.AddEnemyInfo(enemyParty);
            FightScreen.PopulateSubNames(mainParty);
            FightScreen.PrintFightScreen();
            battle.BeginBattle(mainParty, enemyParty);
            
        }
        public void RefreshActiveFightScreen()
        {
            screen.PopulateMainStats(battle.mainParty);
            FightScreen.PopulateEnemyHealth(battle.enemyParty);
            FightScreen.PopulateEnemyMana(battle.enemyParty);
        }
    }
}
