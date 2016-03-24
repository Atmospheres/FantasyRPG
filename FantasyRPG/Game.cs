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
            FightScreen.PopulateFightScreen(screen.screenTemplate);
            FightScreen.AddEnemyInfo(enemyParty);
            FightScreen.PopulateSubNames(mainParty);
            FightScreen.PrintFightScreen();
            battle.BattleSetup(mainParty, enemyParty);
            while ((battle.mainParty.characterList[0].health + battle.mainParty.characterList[1].health + battle.mainParty.characterList[2].health + battle.mainParty.characterList[3].health) > 0 &&
                (battle.enemyParty.characterList[0].health + battle.enemyParty.characterList[1].health + battle.enemyParty.characterList[2].health + battle.mainParty.characterList[3].health) > 0)
            {
                RefreshActiveFightScreen();
                FightScreen.PrintFightScreen();
                battle.Turn();
            }

        }
        public void RefreshActiveFightScreen()
        {
            screen.PopulateMainStats(battle.mainParty);
            FightScreen.PopulateEnemyHealth(battle.enemyParty);
            FightScreen.PopulateEnemyMana(battle.enemyParty);
        }
    }
}
