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
        bool playerTurn = true;

        public Battle()
        {
        }

        public void BattleSetup(Party MainParty, Party EnemyParty)
        {
            mainParty = MainParty;
            enemyParty = EnemyParty;

        }
        public void Turn()
        {
            if (playerTurn == true && (mainParty.characterList[0].health + mainParty.characterList[1].health + mainParty.characterList[2].health + mainParty.characterList[3].health) > 0)
            {
                for (int playerIndex = 0; playerIndex < mainParty.characterList.Count; playerIndex++)
                {
                    mainParty.characterList[playerIndex].CheckBuffs();
                    ResetCursors();
                    FightScreen.PrintFightScreen();
                    SelectAction(mainParty.characterList[playerIndex]);
                }
            }
            if (playerTurn == false && (enemyParty.characterList[0].health + enemyParty.characterList[1].health + enemyParty.characterList[2].health + mainParty.characterList[3].health) > 0)
            {
                for (int playerIndex = 0; playerIndex < enemyParty.characterList.Count; playerIndex++)
                {
                    ResetCursors();
                    FightScreen.cursorSectionOne = 1;
                    FightScreen.PrintFightScreen();

                }
            }
        }
        public void ResetCursors()
        {
            FightScreen.cursorSectionOne = 1;
            FightScreen.cursorSectionTwo = 0;
            FightScreen.sectionTwoLength = 7;// change to players skill list length
            FightScreen.cursorSectionThree = 0;
            FightScreen.sectionThreeLength = 7;// change to skill sub  list length
            FightScreen.cursorSectionFour = 0; 
        }
        public void SetThreeOptions(Character Player)
        {
            switch (FightScreen.cursorSectionTwo)
            {
                case 1:
                    Player.characterClass.MoveOneOptions();
                    break;
                case 2:
                    Player.characterClass.MoveTwoOptions();
                    break;
                case 3:
                    Player.characterClass.MoveThreeOptions();
                    break;
                case 4:
                    Player.characterClass.MoveFourOptions();
                    break;
                case 5:
                    Player.characterClass.MoveFiveOptions();
                    break;
                case 6:
                    Player.characterClass.MoveSixOptions();
                    break;
                case 7:
                    Player.characterClass.MoveSevenOptions();
                    break;
                default:
                    break;
            }
        }
        public void SelectAction(Character Player)
        {
            int activeCursor = 1;
            int lastCursor = 0;
            FightScreen.cursorSectionOne = 1;
            ConsoleKey keyInput = Console.ReadKey(true).Key;
            while (activeCursor > 0)
            {
                if (activeCursor == 1)
                {
                    while (activeCursor == 1)
                    {
                        if (keyInput == ConsoleKey.UpArrow)
                        {
                            FightScreen.MoveCursorOneUp();
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.DownArrow)
                        {
                            FightScreen.MoveCursorOneDown();
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.Enter)
                        {
                            if (FightScreen.cursorSectionOne == 1)
                            {
                                activeCursor = 4;
                                lastCursor = 1;
                                FightScreen.cursorSectionFour = 5;
                                FightScreen.PrintFightScreen();
                                keyInput = Console.ReadKey(true).Key;
                            }
                            else if (FightScreen.cursorSectionOne == 2)
                            {
                                activeCursor = 0;
                                lastCursor = 1;
                                FightScreen.PrintFightScreen();
                                keyInput = Console.ReadKey(true).Key;
                                Player.Defend();
                            }
                            else if (FightScreen.cursorSectionOne == 3)
                            {
                                activeCursor = 2;
                                lastCursor = 1;
                                FightScreen.cursorSectionTwo = 1;
                                FightScreen.ClearSectionTwo();
                                FightScreen.sectionTwoLength = Player.characterClass.KnownSkillList.Count();
                                FightScreen.PopulateSectionTwoSkills(Player.characterClass.KnownSkillList);
                                FightScreen.PrintFightScreen();
                                keyInput = Console.ReadKey(true).Key;
                            }
                            else if (FightScreen.cursorSectionOne == 4)
                            {
                                activeCursor = 2;
                                lastCursor = 1;
                                FightScreen.ClearSectionTwo();
                                FightScreen.sectionTwoLength = mainParty.inventoryNames.Count();
                                FightScreen.PopulateSectionTwoItems(mainParty.inventoryNames);
                                FightScreen.cursorSectionTwo = 1;
                                FightScreen.PrintFightScreen();
                                keyInput = Console.ReadKey(true).Key;
                            }
                        }
                        else
                        {
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                    }
                }
                if(activeCursor ==2)
                {
                    while (activeCursor == 2)
                     {
                        if (keyInput == ConsoleKey.UpArrow)
                        {
                            FightScreen.MoveCursorTwoUp();
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.DownArrow)
                        {
                            FightScreen.MoveCursorTwoDown();
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.Enter)
                        {
                            SetThreeOptions(Player);
                            FightScreen.sectionThreeLength = Player.characterClass.subSkillList.Count();
                            if (FightScreen.sectionThreeLength > 0)
                            {
                                activeCursor = 3;
                                lastCursor = 2;
                                FightScreen.PopulateSectionThree(Player.characterClass.subSkillList);
                                FightScreen.PopulateSectionTwoSkills(Player.characterClass.KnownSkillList);
                                FightScreen.cursorSectionThree = 1;
                                FightScreen.PrintFightScreen();
                                keyInput = Console.ReadKey(true).Key;
                            }
                            else
                            {
                                activeCursor = 4;
                                lastCursor = 2;
                                FightScreen.cursorSectionFour = 5;
                                FightScreen.PrintFightScreen();
                                keyInput = Console.ReadKey(true).Key;
                            }

                        }
                        else if (keyInput == ConsoleKey.Spacebar)
                        {
                            FightScreen.ClearSectionTwo();
                            FightScreen.cursorSectionTwo = 0;
                            FightScreen.PrintFightScreen();
                            activeCursor = 1;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else
                        {
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                    }
                }
                if(activeCursor == 3)
                {
                    while (activeCursor == 3)
                    {
                        if (keyInput == ConsoleKey.UpArrow)
                        {
                            FightScreen.MoveCursorThreeUp();
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.DownArrow)
                        {
                            FightScreen.MoveCursorThreeDown();
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.Enter)
                        {
                            FightScreen.cursorSectionFour = 1;
                            FightScreen.PrintFightScreen();
                            activeCursor = 4;
                            lastCursor = 3;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.Spacebar)
                        {
                            FightScreen.ClearSectionThree(); 
                            FightScreen.cursorSectionThree = 0;
                            FightScreen.PrintFightScreen();
                            activeCursor = 2;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else
                        {
                            FightScreen.PrintFightScreen();
                            keyInput = Console.ReadKey(true).Key;
                        }
                    }
                }
                if(activeCursor == 4)
                {
                    while (activeCursor == 4)
                    {
                        if (keyInput == ConsoleKey.UpArrow)
                        {
                            FightScreen.MoveCursorFourUp();
                            FightScreen.PrintFightScreen();
                            keyInput = ConsoleKey.Clear;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.DownArrow)
                        {
                            FightScreen.MoveCursorFourDown();
                            FightScreen.PrintFightScreen();
                            keyInput = ConsoleKey.Clear;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.LeftArrow)
                        {
                            FightScreen.MoveCursorFourLeft();
                            FightScreen.PrintFightScreen();
                            keyInput = ConsoleKey.Clear;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.RightArrow)
                        {
                            FightScreen.MoveCursorFourRight();
                            FightScreen.PrintFightScreen();
                            keyInput = ConsoleKey.Clear;
                            keyInput = Console.ReadKey(true).Key;
                        }
                        else if (keyInput == ConsoleKey.Enter)
                        {
                            if (FightScreen.cursorSectionOne == 1)
                            {
                                if (FightScreen.cursorSectionFour > 4)
                                {
                                    int element = 0;
                                    enemyParty.characterList[(FightScreen.cursorSectionFour - 5)].RecieveAttack(Player.Attack(), element);
                                    ResetCursors();
                                    FightScreen.AddEnemyInfo(enemyParty);
                                    FightScreen.PrintFightScreen();
                                    keyInput = ConsoleKey.Clear;
                                    activeCursor = 0;
                                }
                                else if (FightScreen.cursorSectionFour < 5)
                                {
                                    int element = 0;
                                    mainParty.characterList[(FightScreen.cursorSectionFour - 1)].RecieveAttack(Player.Attack(), element);
                                    ResetCursors();
                                    FightScreen.AddEnemyInfo(enemyParty);
                                    FightScreen.PrintFightScreen();
                                    keyInput = ConsoleKey.Clear;
                                    activeCursor = 0;
                                }
                            }
                            else if (FightScreen.cursorSectionOne == 3)
                            {
                                   /*int element = 0;
                                   enemyParty.characterList[(FightScreen.cursorSectionFour - 5)].RecieveAttack(Player.Attack(), element);
                                   ResetCursors();
                                   FightScreen.AddEnemyInfo(enemyParty);
                                   FightScreen.PrintFightScreen();
                                   keyInput = ConsoleKey.Clear; 
                                   */
                                activeCursor = 0;
                            }
                            else if (FightScreen.cursorSectionOne == 4)
                            {
                                /* int element = 0;
                                 enemyParty.characterList[(FightScreen.cursorSectionFour - 5)].RecieveAttack(Player.Attack(), element);
                                 ResetCursors();
                                 FightScreen.AddEnemyInfo(enemyParty);
                                 FightScreen.PrintFightScreen();
                                 keyInput = ConsoleKey.Clear; */
                                activeCursor = 0;
                            }

                        }
                        else if (keyInput == ConsoleKey.Spacebar)
                        {
                            FightScreen.cursorSectionFour = 0;
                            FightScreen.PrintFightScreen();
                            keyInput = ConsoleKey.Clear;
                            keyInput = Console.ReadKey(true).Key;
                            activeCursor = lastCursor;
                        }
                        else
                        {
                            FightScreen.PrintFightScreen();
                            keyInput = ConsoleKey.Clear;
                            keyInput = Console.ReadKey(true).Key;
                        }
                    }
                }
            }
        }
    }
}
