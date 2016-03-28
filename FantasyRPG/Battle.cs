using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Battle
    {
        public Party mainParty = new Party();
        public Party enemyParty = new Party();
        public Party tempParty = new Party();
        bool playerTurn = true;

        public Battle()
        {
        }

        public void BeginBattle(Party MainParty, Party EnemyParty)
        {
            mainParty = MainParty;
            enemyParty = EnemyParty;
            FightScreen.AddEnemyInfo(enemyParty);
            FightScreen.PopulateMainStats(mainParty);
            FightScreen.PrintFightScreen();
            while (((mainParty.characterList[0].health + mainParty.characterList[1].health + mainParty.characterList[2].health + mainParty.characterList[3].health) > 0)
                 && (enemyParty.characterList.Count() > 0))
            {
                Turn();
            }
            if((mainParty.characterList[0].health + mainParty.characterList[1].health + mainParty.characterList[2].health + mainParty.characterList[3].health) == 0)
            {
                Console.WriteLine("You Lose!");
            }
            else if((enemyParty.characterList.Count() == 0))
            {
                Console.WriteLine("You Win!");
                // mainparty gold and xp + enemy gold and xp
            }

        }
        public void Turn()
        {
            if (playerTurn == true && (mainParty.characterList[0].health + mainParty.characterList[1].health + mainParty.characterList[2].health + mainParty.characterList[3].health) > 0)
            {
                for (int playerIndex = 0; playerIndex < mainParty.characterList.Count; playerIndex++)
                {
                    if (mainParty.characterList[playerIndex].health > 0)
                    {
                        if (enemyParty.characterList.Count() > 0)
                        {
                            mainParty.characterList[playerIndex].CheckBuffs();
                            ResetCursors();
                            
                            FightScreen.AddEnemyInfo(enemyParty);
                            FightScreen.cursorSectionOne = 1;
                            FightScreen.PrintFightScreen();
                            SelectAction(mainParty.characterList[playerIndex], playerIndex);
                            CheckDeath();
                        }
                    }
                }
                FightScreen.playerturn = false;
            }
            else if (playerTurn == false && (enemyParty.characterList[0].health + enemyParty.characterList[1].health + enemyParty.characterList[2].health + mainParty.characterList[3].health) > 0)
            {
                for (int playerIndex = 0; playerIndex < enemyParty.characterList.Count; playerIndex++)
                {
                    if (enemyParty.characterList[playerIndex].health > 0)
                    {

                    }  
                }
                FightScreen.playerturn = true;
            }
        }
        public void CheckDeath()
        {
            int playerCount = enemyParty.characterList.Count();
            for (int i = 0; i < playerCount; i++) 
            {
                if (enemyParty.characterList[i].health == 0)
                {
                    enemyParty.characterList.RemoveRange(i,1);
                    playerCount--;
                    i--;
                    FightScreen.AddEnemyInfo(enemyParty);
                    FightScreen.PrintFightScreen();

                }
            }
        }
        public void ResetCursors()
        {
            FightScreen.cursorSectionOne = 1;
            FightScreen.cursorSectionTwo = 0;
            FightScreen.sectionTwoLength = 0;
            FightScreen.cursorSectionThree = 0;
            FightScreen.sectionThreeLength = 0;
            FightScreen.cursorSectionFour = 0; 
        }
        public void SetThreeOptions(Character Player)
        {
            FightScreen.PopulateSectionThree(Player.characterClass.knownSkillList[(FightScreen.cursorSectionTwo - 1)].subSkillList, Player.characterClass.knownSkillList[(FightScreen.cursorSectionTwo - 1)].subSkillType);
        }
        public void SplitTempParty(Party TempParty)
        {
            for(int i = 0; i < 4; i++)
            {
                mainParty.characterList[i] = TempParty.characterList[i];
            }
            for (int i = 4; i < TempParty.characterList.Count(); i++)
            {
                enemyParty.characterList[i-4] = TempParty.characterList[i];
            }

        }
        public void SelectAction(Character Player, int PlayerIndex)
        {
            FightScreen.activeCursor = 1;
            FightScreen.lastCursor = 0;
            FightScreen.cursorSectionOne = 1;
            FightScreen.keyInput = Console.ReadKey(true).Key;
            while (FightScreen.activeCursor > 0)
            {
                if (FightScreen.activeCursor == 1)
                {
                    while (FightScreen.activeCursor == 1)
                    {
                        UseCursorOne(Player);
                    }
                }
                if(FightScreen.activeCursor ==2)
                {
                    while (FightScreen.activeCursor == 2)
                     {
                        UseCursorTwo(Player);
                    }
                }
                if(FightScreen.activeCursor == 3)
                {
                    while (FightScreen.activeCursor == 3)
                    {
                        UseCursorThree(Player);
                    }
                }
                if(FightScreen.activeCursor == 4)
                {
                    while (FightScreen.activeCursor == 4)
                    {
                        UseCursorFour(Player, PlayerIndex);
                    }
                }
            }
        }

        public void UseCursorOne(Character Player)
        {
            if (FightScreen.keyInput == ConsoleKey.UpArrow)
            {
                FightScreen.MoveCursorOneUp();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.DownArrow)
            {
                FightScreen.MoveCursorOneDown();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.Enter)
            {
                if (FightScreen.cursorSectionOne == 1)
                {
                    FightScreen.activeCursor = 4;
                    FightScreen.lastCursor = 1;
                    FightScreen.cursorSectionFour = 5;
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = Console.ReadKey(true).Key;
                }
                else if (FightScreen.cursorSectionOne == 2)
                {
                    FightScreen.activeCursor = 0;
                    FightScreen.lastCursor = 1;
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = Console.ReadKey(true).Key;
                    Player.Defend();
                }
                else if (FightScreen.cursorSectionOne == 3)
                {
                    FightScreen.activeCursor = 2;
                    FightScreen.lastCursor = 1;
                    FightScreen.cursorSectionTwo = 1;
                    FightScreen.ClearSectionTwo();
                    FightScreen.sectionTwoLength = Player.characterClass.knownSkillList.Count();
                    FightScreen.PopulateSectionTwoSkills(Player.characterClass.skillNames);
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = Console.ReadKey(true).Key;
                }
                else if (FightScreen.cursorSectionOne == 4)
                {
                    FightScreen.activeCursor = 2;
                    FightScreen.lastCursor = 1;
                    FightScreen.ClearSectionTwo();
                    FightScreen.sectionTwoLength = mainParty.inventoryNames.Count();
                    FightScreen.PopulateSectionTwoItems(mainParty.inventoryNames);
                    FightScreen.cursorSectionTwo = 1;
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = Console.ReadKey(true).Key;
                }
            }
            else
            {
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
        }
        public void UseCursorTwo(Character Player)
        {
            if (FightScreen.keyInput == ConsoleKey.UpArrow)
            {
                FightScreen.MoveCursorTwoUp();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.DownArrow)
            {
                FightScreen.MoveCursorTwoDown();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.Enter)
            {
                SetThreeOptions(Player);
                FightScreen.sectionThreeLength = Player.characterClass.knownSkillList[FightScreen.cursorSectionTwo - 1].subSkillList.Count();
                if (FightScreen.sectionThreeLength > 0)
                {
                    FightScreen.activeCursor = 3;
                    FightScreen.lastCursor = 2;
                    FightScreen.PopulateSectionThree(Player.characterClass.subSkillList, Player.characterClass.knownSkillList[FightScreen.cursorSectionTwo - 1].subSkillType);
                    FightScreen.cursorSectionThree = 1;
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = Console.ReadKey(true).Key;
                }
                else
                {
                    FightScreen.activeCursor = 4;
                    FightScreen.lastCursor = 2;
                    FightScreen.cursorSectionFour = Player.characterClass.knownSkillList[FightScreen.cursorSectionTwo - 1].cursorFourStart;
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = Console.ReadKey(true).Key;
                }

            }
            else if (FightScreen.keyInput == ConsoleKey.Spacebar)
            {
                FightScreen.ClearSectionTwo();
                FightScreen.cursorSectionTwo = 0;
                FightScreen.PrintFightScreen();
                FightScreen.activeCursor = 1;
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else
            {
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
        }
        public void UseCursorThree(Character Player)
        {
            if (FightScreen.keyInput == ConsoleKey.UpArrow)
            {
                FightScreen.MoveCursorThreeUp();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.DownArrow)
            {
                FightScreen.MoveCursorThreeDown();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.Enter)
            {
                FightScreen.cursorSectionFour = Player.characterClass.knownSkillList[FightScreen.cursorSectionTwo -1].cursorFourStart;
                FightScreen.PrintFightScreen();
                FightScreen.activeCursor = 4;
                FightScreen.lastCursor = 3;
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.Spacebar)
            {
                FightScreen.ClearSectionThree(); 
                FightScreen.cursorSectionThree = 0;
                FightScreen.PrintFightScreen();
                FightScreen.activeCursor = 2;
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else
            {
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
        }
        public void UseCursorFour(Character Player, int PlayerIndex)
        {
            if (FightScreen.keyInput == ConsoleKey.UpArrow)
            {
                FightScreen.MoveCursorFourUp();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.DownArrow)
            {
                FightScreen.MoveCursorFourDown();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.LeftArrow)
            {
                FightScreen.MoveCursorFourLeft();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.RightArrow)
            {
                FightScreen.MoveCursorFourRight();
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
            else if (FightScreen.keyInput == ConsoleKey.Enter)
            {
                if (FightScreen.cursorSectionOne == 1)
                {
                    if (FightScreen.cursorSectionFour > 4)
                    {
                        int element = 0;
                        this.enemyParty.characterList[(FightScreen.cursorSectionFour - 5)].RecieveAttack(Player.Attack(), element);
                        ResetCursors();
                        FightScreen.AddEnemyInfo(this.enemyParty);
                        FightScreen.PrintFightScreen();
                        FightScreen.activeCursor = 0;
                    }
                    else if (FightScreen.cursorSectionFour < 5)
                    {
                        int element = 0;
                        mainParty.characterList[(FightScreen.cursorSectionFour - 1)].RecieveAttack(Player.Attack(), element);
                        ResetCursors();
                        FightScreen.AddEnemyInfo(this.enemyParty);
                        FightScreen.PrintFightScreen();
                        FightScreen.activeCursor = 0;
                    }
                }
                else if (FightScreen.cursorSectionOne == 3)
                {

                    tempParty = Player.characterClass.knownSkillList[FightScreen.cursorSectionTwo - 1].SkillEffect(mainParty, enemyParty, PlayerIndex);
                    SplitTempParty(tempParty);
                    ResetCursors();
                    FightScreen.ClearSectionTwo();
                    FightScreen.ClearSectionThree();
                    FightScreen.AddEnemyInfo(this.enemyParty);
                    FightScreen.PrintFightScreen();
                    FightScreen.keyInput = ConsoleKey.Clear;
                    FightScreen.activeCursor = 0;
                }
                else if (FightScreen.cursorSectionOne == 4)
                {
                    /* Items */
                    FightScreen.activeCursor = 0;
                }

            }
            else if (FightScreen.keyInput == ConsoleKey.Spacebar)
            {
                FightScreen.cursorSectionFour = 0;
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = ConsoleKey.Clear;
                FightScreen.keyInput = Console.ReadKey(true).Key;
                FightScreen.activeCursor = FightScreen.lastCursor;
            }
            else
            {
                FightScreen.PrintFightScreen();
                FightScreen.keyInput = ConsoleKey.Clear;
                FightScreen.keyInput = Console.ReadKey(true).Key;
            }
        }
    }
}
