using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    static class FightScreen 
    {
        public static int cursorSectionOne = 0;
        public static int cursorSectionTwo = 0;
        public static int sectionTwoLength;
        public static int cursorSectionThree = 0;
        public static int sectionThreeLength;
        public static int cursorSectionFour = 0;
        public static int activeCursor = 1;
        public static int lastCursor = 0;
        public static bool playerturn = true;
        public static ConsoleKey keyInput = Console.ReadKey(true).Key;
        static public char[,] fightTemplate = new char[48, 64];

        static public void MoveCursorOneUp()
        {
            if (cursorSectionOne > 1)
            {
                cursorSectionOne -= 1;
            }
        }
        static public void MoveCursorOneDown()
        {
            if(cursorSectionOne < 4)
            {
                cursorSectionOne += 1;
            }
        }
        static public void MoveCursorTwoUp()
        {
            if (cursorSectionTwo > 1)
            {
                cursorSectionTwo -= 1;
            }
        }
        static public void MoveCursorTwoDown()
        {
            if (cursorSectionTwo < sectionTwoLength)
            {
                cursorSectionTwo += 1;
            }
        }
        static public void MoveCursorThreeUp()
        {
            if (cursorSectionThree > 1)
            {
                cursorSectionThree -= 1;
            }
        }
        static public void MoveCursorThreeDown()
        {
            if (cursorSectionThree < (sectionThreeLength))
            {
                cursorSectionThree += 1;
            }
        }
        static public void MoveCursorFourUp()
        {
            if (cursorSectionFour > 1 && cursorSectionFour != 5 && cursorSectionFour < 9)
            {
                cursorSectionFour -= 1;
            }
        }
        static public void MoveCursorFourDown()
        {
            if (cursorSectionFour > 0 && cursorSectionFour < 4)
            {
                cursorSectionFour += 1;
            }
            if (cursorSectionFour > 4 && cursorSectionFour < 8)
            {
                cursorSectionFour += 1;
            }
        }
        static public void MoveCursorFourLeft()
        {
            if (cursorSectionFour == 10)
            {
                cursorSectionFour = 9;
            }
                if (cursorSectionFour > 4 && cursorSectionFour < 9)
            {
                cursorSectionFour -= 4;
            }
        }
        static public void MoveCursorFourRight()
        {
            if (cursorSectionFour == 9)
            {
                cursorSectionFour = 10;
            }
            if (cursorSectionFour < 5)
            {
                cursorSectionFour += 4;
            }
        }
        static public void PopulateSectionTwoSkills(List<string> SkillList)
        {
            int optionsLength = SkillList.Count();
            fightTemplate[9, 2] = 'S';
            fightTemplate[9, 3] = 'K';
            fightTemplate[9, 4] = 'I';
            fightTemplate[9, 5] = 'L';
            fightTemplate[9, 6] = 'L';
            fightTemplate[9, 7] = 'S';
            fightTemplate[9, 8] = ':';
            for (int skillListIndex = 0; skillListIndex < optionsLength; skillListIndex++)
            {
                char[] skillCharArray;
                skillCharArray = SkillList[skillListIndex].ToCharArray();
                for (int skillArrayIndex = 0; skillArrayIndex < skillCharArray.Count(); skillArrayIndex++)
                {
                    fightTemplate[(skillListIndex + 10), (skillArrayIndex + 2)] = skillCharArray[skillArrayIndex];
                }
            }
        }
        static public void PopulateSectionTwoItems(List<string> SkillList)
        {
            int optionsLength = SkillList.Count();
            fightTemplate[9, 2] = 'I';
            fightTemplate[9, 3] = 'T';
            fightTemplate[9, 4] = 'E';
            fightTemplate[9, 5] = 'M';
            fightTemplate[9, 6] = 'S';
            fightTemplate[9, 7] = ':';
            for (int skillListIndex = 0; skillListIndex < optionsLength; skillListIndex++)
            {
                char[] skillCharArray;
                skillCharArray = SkillList[skillListIndex].ToCharArray();
                for (int skillArrayIndex = 0; skillArrayIndex < skillCharArray.Count(); skillArrayIndex++)
                {
                    fightTemplate[(skillListIndex + 10), (skillArrayIndex + 2)] = skillCharArray[skillArrayIndex];
                }
            }
        }
    
        static public void ClearSectionTwo()
        {
            for(int i = 9; i < 17; i++)
            {
                for(int j = 2; j < 13; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
                
        }
        static public void PopulateSectionThree(List<string> SubSkillList, string Type)
        {
            if (Type != "None")
            {
                char[] typeCharArray;
                typeCharArray = Type.ToCharArray();
                for (int typeArrayIndex = 0; typeArrayIndex < typeCharArray.Length; typeArrayIndex++)
                {
                    fightTemplate[19, (typeArrayIndex + 2)] = typeCharArray[typeArrayIndex];
                }
                int optionsLength = SubSkillList.Count();
                for (int subSkillListIndex = 0; subSkillListIndex < optionsLength; subSkillListIndex++)
                {
                    char[] subSkillCharArray;
                    subSkillCharArray = SubSkillList[subSkillListIndex].ToCharArray();
                    for (int subSkillArrayIndex = 0; subSkillArrayIndex < subSkillCharArray.Count(); subSkillArrayIndex++)
                    {
                        fightTemplate[(subSkillListIndex + 20), (subSkillArrayIndex + 2)] = subSkillCharArray[subSkillArrayIndex];
                    }
                }
            }
        }
        static public void ClearSectionThree()
        {
            for (int i = 19; i < 27; i++)
            {
                for (int j = 2; j < 13; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }

        } 
        static public void PrintFightScreen()
        {
            Console.Clear();
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }
            Console.Write(fightTemplate[10, 0]);
            Console.Write(fightTemplate[10, 1]);
            if(cursorSectionTwo == 1)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for(int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[10, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[10, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[11, 0]);
            Console.Write(fightTemplate[11, 1]);
            if (cursorSectionTwo == 2)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[11, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[11, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[12, 0]);
            Console.Write(fightTemplate[12, 1]);
            if (cursorSectionTwo == 3)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[12, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[12, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[13, 0]);
            Console.Write(fightTemplate[13, 1]);
            if (cursorSectionTwo == 4)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[13, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[13, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[14, 0]);
            Console.Write(fightTemplate[14, 1]);
            if (cursorSectionTwo == 5)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[14, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[14, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[15, 0]);
            Console.Write(fightTemplate[15, 1]);
            if (cursorSectionTwo == 6)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[15, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[15, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[16, 0]);
            Console.Write(fightTemplate[16, 1]);
            if (cursorSectionTwo == 7)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[16, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[16, col]);
            }
            Console.WriteLine();
            for (int row = 18; row < 20; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }


            Console.Write(fightTemplate[20, 0]);
            Console.Write(fightTemplate[20, 1]);

            if (cursorSectionThree == 1)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[20, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[20, col]);
            }


            Console.WriteLine();
            Console.Write(fightTemplate[21, 0]);
            Console.Write(fightTemplate[21, 1]);
            if (cursorSectionThree == 2)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[21, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[21, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[22, 0]);
            Console.Write(fightTemplate[22, 1]);
            if (cursorSectionThree == 3)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[22, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[22, col]);
            }
            Console.WriteLine();




            Console.Write(fightTemplate[23, 0]);
            Console.Write(fightTemplate[23, 1]);
            if (cursorSectionThree == 4)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[23, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[23, col]);
            }
            Console.WriteLine();


            




            Console.Write(fightTemplate[24, 0]);
            Console.Write(fightTemplate[24, 1]);
            if (cursorSectionThree == 5)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[24, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[24, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[25, 0]);
            Console.Write(fightTemplate[25, 1]);
            if (cursorSectionThree == 6)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[25, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[25, col]);
            }
            Console.WriteLine();


            Console.Write(fightTemplate[26, 0]);
            Console.Write(fightTemplate[26, 1]);
            if (cursorSectionThree == 7)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 14; col++)
            {
                Console.Write(fightTemplate[26, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 14; col < 64; col++)
            {
                Console.Write(fightTemplate[26, col]);
            }
            Console.WriteLine();



            for (int row = 27; row < 41; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }
            Console.Write(fightTemplate[41, 0]);
            Console.Write(fightTemplate[41, 1]);
            if (cursorSectionOne == 1)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 12; col++)
            {
                Console.Write(fightTemplate[41, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[41, 12]);
            Console.Write(fightTemplate[41, 13]);
            if (cursorSectionFour == 1 || cursorSectionFour == 9)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 14; col < 24; col++)
            {
                Console.Write(fightTemplate[41, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[41, 24]);
            Console.Write(fightTemplate[41, 25]);
            if (cursorSectionFour == 5 || cursorSectionFour == 10)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 26; col < 38; col++)
            {
                Console.Write(fightTemplate[41, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[41, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[42, 0]);
            Console.Write(fightTemplate[42, 1]);
            if (cursorSectionOne == 2)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 12; col++)
            {
                Console.Write(fightTemplate[42, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[42, 12]);
            Console.Write(fightTemplate[42, 13]);
            if (cursorSectionFour == 2 || cursorSectionFour == 9)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 14; col < 24; col++)
            {
                Console.Write(fightTemplate[42, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[42, 24]);
            Console.Write(fightTemplate[42, 25]);
            if (cursorSectionFour == 6 || cursorSectionFour == 10)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 26; col < 38; col++)
            {
                Console.Write(fightTemplate[42, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[42, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[43, 0]);
            Console.Write(fightTemplate[43, 1]);
            if (cursorSectionOne == 3)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 12; col++)
            {
                Console.Write(fightTemplate[43, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[43, 12]);
            Console.Write(fightTemplate[43, 13]);
            if (cursorSectionFour == 3 || cursorSectionFour == 9)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 14; col < 24; col++)
            {
                Console.Write(fightTemplate[43, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[43, 24]);
            Console.Write(fightTemplate[43, 25]);
            if (cursorSectionFour == 7 || cursorSectionFour == 10)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 26; col < 38; col++)
            {
                Console.Write(fightTemplate[43, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[43, col]);
            }
            Console.WriteLine();
            Console.Write(fightTemplate[44, 0]);
            Console.Write(fightTemplate[44, 1]);
            if (cursorSectionOne == 4)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 2; col < 12; col++)
            {
                Console.Write(fightTemplate[44, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[44, 12]);
            Console.Write(fightTemplate[44, 13]);
            if (cursorSectionFour == 4 || cursorSectionFour == 9)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 14; col < 24; col++)
            {
                Console.Write(fightTemplate[44, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(fightTemplate[44, 24]);
            Console.Write(fightTemplate[44, 25]);
            if (cursorSectionFour == 8 || cursorSectionFour == 10)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            for (int col = 26; col < 38; col++)
            {
                Console.Write(fightTemplate[44, col]);
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[44, col]);
            }
            Console.WriteLine();
            for (int row = 45; row < 48; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }

        }
        static public void PopulateFightScreen(ScreenTemplate Template)
        {
            for (int i = 0; i < 48; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    fightTemplate[i, j] = Template.screenTemplate[i, j];
                }
            }
            AddFightElements();
        }
        static public void PopulateSubNames(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] nameCharArray;
                nameCharArray = MainParty.characterList[characterListIndex].name.ToCharArray();
                for (int nameArrayIndex = 0; nameArrayIndex < nameCharArray.Count(); nameArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 41), (nameArrayIndex + 14)] = nameCharArray[nameArrayIndex];
                }
            }
        }
  
        static public void AddFightElements()
        {
            AddFightOptions();
            AddCombatLog();
            AddSideContainers();
            AddBottomContainer();
        }
        static public void AddEnemyInfo(Party EnemyParty)
        {

            PopulateEnemyNames(EnemyParty);
            PopulateEnemyHealth(EnemyParty);
            PopulateEnemyMana(EnemyParty);
        }

        static public void PopulateEnemyNames(Party EnemyParty)
        {
            ClearEnemyNames();
            for (int characterListIndex = 0; characterListIndex < EnemyParty.characterList.Count(); characterListIndex++)
            {
                char[] nameCharArray;
                nameCharArray = EnemyParty.characterList[characterListIndex].name.ToCharArray();
                for (int nameArrayIndex = 0; nameArrayIndex < nameCharArray.Count(); nameArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 41), (nameArrayIndex + 26)] = nameCharArray[nameArrayIndex];
                }
            }
        }
        static public void ClearEnemyNames()
        {
            for (int i = 41; i < 45; i++)
            {
                for (int j = 26; j < 38; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
        }
        static public void PopulateEnemyHealth(Party EnemyParty)
        {
            ClearEnemyHealth();
            for (int characterListIndex = 0; characterListIndex < EnemyParty.characterList.Count(); characterListIndex++)
            {
                
                char[] healthCharArray;
                string healthString;
                char[] healthMaxCharArray;
                string healthMaxString;
                healthString = EnemyParty.characterList[characterListIndex].health.ToString();
                healthCharArray = healthString.ToCharArray();
                healthMaxString = EnemyParty.characterList[characterListIndex].healthMax.ToString();
                healthMaxCharArray = healthMaxString.ToCharArray();
                for (int healthArrayIndex = 0; healthArrayIndex < healthCharArray.Count(); healthArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 41), (healthArrayIndex + 43)] = healthCharArray[healthArrayIndex];
                }
                for (int healthMaxArrayIndex = 0; healthMaxArrayIndex < healthMaxCharArray.Count(); healthMaxArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 41), (healthMaxArrayIndex + 47)] = healthMaxCharArray[healthMaxArrayIndex];
                }
            }
        }
        static public void ClearEnemyHealth()
        {
            for (int i = 41; i < 45; i++)
            {
                for (int j = 43; j < 46; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
            for (int i = 41; i < 45; i++)
            {
                for (int j = 47; j < 50; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
        }
        static public void PopulateEnemyMana(Party EnemyParty)
        {
            ClearEnemyMana();
            for (int characterListIndex = 0; characterListIndex < EnemyParty.characterList.Count(); characterListIndex++)
            {
                
                char[] manaCharArray;
                string manaString;
                char[] manaMaxCharArray;
                string manaMaxString;
                manaString = EnemyParty.characterList[characterListIndex].mana.ToString();
                manaCharArray = manaString.ToCharArray();
                manaMaxString = EnemyParty.characterList[characterListIndex].manaMax.ToString();
                manaMaxCharArray = manaMaxString.ToCharArray();
                for (int manaArrayIndex = 0; manaArrayIndex < manaCharArray.Count(); manaArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 41), (manaArrayIndex + 54)] = manaCharArray[manaArrayIndex];
                }
                for (int manaMaxArrayIndex = 0; manaMaxArrayIndex < manaMaxCharArray.Count(); manaMaxArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 41), (manaMaxArrayIndex + 58)] = manaMaxCharArray[manaMaxArrayIndex];
                }
            }
        }
        static public void ClearEnemyMana()
        {
            for (int i = 41; i < 45; i++)
            {
                for (int j = 54; j < 57; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
            for (int i = 41; i < 45; i++)
            {
                for (int j = 58; j < 61; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
        }
        static public void PopulateMainStats(Party MainParty)
        {
            PopulateMainHealth(MainParty);
            PopulateMainMana(MainParty);
            PopulateMainStrength(MainParty);
            PopulateMainConstitution(MainParty);
            PopulateMainDexterity(MainParty);
            PopulateMainIntelligence(MainParty);
            PopulateMainPiety(MainParty);
        }
        static public void PopulateMainPiety(Party MainParty)
        {
            ClearPiety();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] pietyCharArray;
                string pietyString;
                pietyString = MainParty.characterList[characterListIndex].piety.ToString();
                pietyCharArray = pietyString.ToCharArray();
                for (int pietyArrayIndex = 0; pietyArrayIndex < pietyCharArray.Count(); pietyArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (pietyArrayIndex + 60)] = pietyCharArray[pietyArrayIndex];
                }
            }
        }
        static public void ClearPiety()
        {
            for (int i = 2; i < 6; i++)    
            {
                for(int j = 60; j < 62; j++)
                {
                    fightTemplate[i,j] = ' ';
                }

            }
        }
        static public void PopulateMainIntelligence(Party MainParty)
        {
            ClearIntelligence();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] intelligenceCharArray;
                string intelligenceString;
                intelligenceString = MainParty.characterList[characterListIndex].intelligence.ToString();
                intelligenceCharArray = intelligenceString.ToCharArray();
                for (int intelligenceArrayIndex = 0; intelligenceArrayIndex < intelligenceCharArray.Count(); intelligenceArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (intelligenceArrayIndex + 55)] = intelligenceCharArray[intelligenceArrayIndex];
                }
            }
        }
        static public void ClearIntelligence()
        {
            for (int i = 2; i < 6; i++)
            {
                for (int j = 55; j < 57; j++)
                {
                    fightTemplate[i, j] = ' ';
                }

            }
        }
        static public void PopulateMainDexterity(Party MainParty)
        {
            ClearDexterity();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] dexterityCharArray;
                string dexterityString;
                dexterityString = MainParty.characterList[characterListIndex].dexterity.ToString();
                dexterityCharArray = dexterityString.ToCharArray();
                for (int constitutionArrayIndex = 0; constitutionArrayIndex < dexterityCharArray.Count(); constitutionArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (constitutionArrayIndex + 50)] = dexterityCharArray[constitutionArrayIndex];
                }
            }
        }
        static public void ClearDexterity()
        {
            for (int i = 2; i < 6; i++)
            {
                for (int j = 50; j < 52; j++)
                {
                    fightTemplate[i, j] = ' ';
                }

            }
        }
        static public void PopulateMainConstitution(Party MainParty)
        {
            ClearConstitution();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] constitutionCharArray;
                string constitutionString;
                constitutionString = MainParty.characterList[characterListIndex].constitution.ToString();
                constitutionCharArray = constitutionString.ToCharArray();
                for (int constitutionArrayIndex = 0; constitutionArrayIndex < constitutionCharArray.Count(); constitutionArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (constitutionArrayIndex + 45)] = constitutionCharArray[constitutionArrayIndex];
                }
            }
        }
        static public void ClearConstitution()
        {
            for (int i = 2; i < 6; i++)
            {
                for (int j = 45; j < 47; j++)
                {
                    fightTemplate[i, j] = ' ';
                }

            }
        }
        static public void PopulateMainStrength(Party MainParty)
        {
            ClearStrength();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] strengthCharArray;
                string strengthString;
                strengthString = MainParty.characterList[characterListIndex].strength.ToString();
                strengthCharArray = strengthString.ToCharArray();
                for (int strengthArrayIndex = 0; strengthArrayIndex < strengthCharArray.Count(); strengthArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (strengthArrayIndex + 40)] = strengthCharArray[strengthArrayIndex];
                }
            }
        }
        static public void ClearStrength()
        {
            for (int i = 2; i < 6; i++)
            {
                for (int j = 40; j < 42; j++)
                {
                    fightTemplate[i, j] = ' ';
                }

            }
        }
        static public void PopulateMainHealth(Party MainParty)
        {
            ClearMainHealth();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] healthCharArray;
                string healthString;
                char[] healthMaxCharArray;
                string healthMaxString;
                healthString = MainParty.characterList[characterListIndex].health.ToString();
                healthCharArray = healthString.ToCharArray();
                healthMaxString = MainParty.characterList[characterListIndex].healthMax.ToString();
                healthMaxCharArray = healthMaxString.ToCharArray();
                for (int healthArrayIndex = 0; healthArrayIndex < healthCharArray.Count(); healthArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (healthArrayIndex + 21)] = healthCharArray[healthArrayIndex];
                }
                for (int healthMaxArrayIndex = 0; healthMaxArrayIndex < healthMaxCharArray.Count(); healthMaxArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (healthMaxArrayIndex + 25)] = healthMaxCharArray[healthMaxArrayIndex];
                }
            }
        }
        static public void ClearMainHealth()
        {
            for (int i = 2; i < 6; i++)
            {
                for (int j = 21; j < 24; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
            for (int i =2; i < 6; i++)
            {
                for (int j = 25; j < 28; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
        }
        static public void PopulateMainMana(Party MainParty)
        {

            ClearMainMana();
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] manaCharArray;
                string manaString;
                char[] manaMaxCharArray;
                string manaMaxString;
                manaString = MainParty.characterList[characterListIndex].mana.ToString();
                manaCharArray = manaString.ToCharArray();
                manaMaxString = MainParty.characterList[characterListIndex].manaMax.ToString();
                manaMaxCharArray = manaMaxString.ToCharArray();
                for (int manaArrayIndex = 0; manaArrayIndex < manaCharArray.Count(); manaArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (manaArrayIndex + 32)] = manaCharArray[manaArrayIndex];
                }
                for (int manaMaxArrayIndex = 0; manaMaxArrayIndex < manaMaxCharArray.Count(); manaMaxArrayIndex++)
                {
                    fightTemplate[(characterListIndex + 2), (manaMaxArrayIndex + 35)] = manaMaxCharArray[manaMaxArrayIndex];
                }
            }
        }
        static public void ClearMainMana()
        {
            for (int i = 2; i < 6; i++)
            {
                for (int j = 32; j < 34; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
            for (int i = 2; i < 6; i++)
            {
                for (int j = 35; j < 27; j++)
                {
                    fightTemplate[i, j] = ' ';
                }
            }
        }
        static public void AddSideContainers()
        {
            for (int i = 9; i < 27; i++)
            {
                fightTemplate[i, 14] = '║';
            }
            for (int j = 2; j < 14; j++)
            {
                fightTemplate[18, j] = '═';
            }
            fightTemplate[8, 14] = '╦';
            fightTemplate[27, 14] = '╩';
            fightTemplate[18, 1] = '╠';
            fightTemplate[18, 14] = '╣';
        }
        static public void AddCombatLog()
        {
            for (int j = 2; j < 62; j++)
            {
                fightTemplate[27, j] = '═';
            }
            fightTemplate[27, 1] = '╠';
            fightTemplate[27, 62] = '╣';
            fightTemplate[28, 2] = 'C';
            fightTemplate[28, 3] = 'O';
            fightTemplate[28, 4] = 'M';
            fightTemplate[28, 5] = 'B';
            fightTemplate[28, 6] = 'A';
            fightTemplate[28, 7] = 'T';
            fightTemplate[28, 9] = 'L';
            fightTemplate[28, 10] = 'O';
            fightTemplate[28, 11] = 'G';
            fightTemplate[28, 12] = ':';
        }
        static public void AddFightOptions()
        {
            fightTemplate[41, 2] = 'A';
            fightTemplate[41, 3] = 'T';
            fightTemplate[41, 4] = 'T';
            fightTemplate[41, 5] = 'A';
            fightTemplate[41, 6] = 'C';
            fightTemplate[41, 7] = 'K';
            fightTemplate[42, 2] = 'D';
            fightTemplate[42, 3] = 'E';
            fightTemplate[42, 4] = 'F';
            fightTemplate[42, 5] = 'E';
            fightTemplate[42, 6] = 'N';
            fightTemplate[42, 7] = 'D';
            fightTemplate[43, 2] = 'S';
            fightTemplate[43, 3] = 'K';
            fightTemplate[43, 4] = 'I';
            fightTemplate[43, 5] = 'L';
            fightTemplate[43, 6] = 'L';
            fightTemplate[43, 7] = 'S';
            fightTemplate[44, 2] = 'I';
            fightTemplate[44, 3] = 'T';
            fightTemplate[44, 4] = 'E';
            fightTemplate[44, 5] = 'M';
            fightTemplate[44, 6] = 'S';
        }
        static public void AddBottomContainer()
        {
            for (int j = 2; j < 62; j++)
            {
                fightTemplate[40, j] = '═';
            }
            fightTemplate[40, 1] = '╠';
            fightTemplate[40, 62] = '╣';
            fightTemplate[40, 12] = '╦';
            fightTemplate[40, 13] = '╦';
            fightTemplate[40, 24] = '╦';
            fightTemplate[40, 25] = '╦';
            fightTemplate[40, 38] = '╦';
            fightTemplate[40, 39] = '╦';
            fightTemplate[40, 50] = '╦';
            fightTemplate[41, 12] = '║';
            fightTemplate[41, 13] = '║';
            fightTemplate[41, 24] = '║';
            fightTemplate[41, 25] = '║';
            fightTemplate[41, 38] = '║';
            fightTemplate[41, 39] = '║';
            fightTemplate[41, 40] = 'H';
            fightTemplate[41, 41] = 'P';
            fightTemplate[41, 42] = ':';
            fightTemplate[41, 46] = '/';
            fightTemplate[41, 50] = '║';
            fightTemplate[41, 51] = 'M';
            fightTemplate[41, 52] = 'P';
            fightTemplate[41, 53] = ':';
            fightTemplate[41, 57] = '/';
            fightTemplate[42, 12] = '║';
            fightTemplate[42, 13] = '║';
            fightTemplate[42, 24] = '║';
            fightTemplate[42, 25] = '║';
            fightTemplate[42, 38] = '║';
            fightTemplate[42, 39] = '║';
            fightTemplate[42, 40] = 'H';
            fightTemplate[42, 41] = 'P';
            fightTemplate[42, 42] = ':';
            fightTemplate[42, 46] = '/';
            fightTemplate[42, 50] = '║';
            fightTemplate[42, 51] = 'M';
            fightTemplate[42, 52] = 'P';
            fightTemplate[42, 53] = ':';
            fightTemplate[42, 57] = '/';
            fightTemplate[43, 12] = '║';
            fightTemplate[43, 13] = '║';
            fightTemplate[43, 24] = '║';
            fightTemplate[43, 25] = '║';
            fightTemplate[43, 38] = '║';
            fightTemplate[43, 39] = '║';
            fightTemplate[43, 40] = 'H';
            fightTemplate[43, 41] = 'P';
            fightTemplate[43, 42] = ':';
            fightTemplate[43, 46] = '/';
            fightTemplate[43, 50] = '║';
            fightTemplate[43, 51] = 'M';
            fightTemplate[43, 52] = 'P';
            fightTemplate[43, 53] = ':';
            fightTemplate[43, 57] = '/';
            fightTemplate[44, 12] = '║';
            fightTemplate[44, 13] = '║';
            fightTemplate[44, 24] = '║';
            fightTemplate[44, 25] = '║';
            fightTemplate[44, 38] = '║';
            fightTemplate[44, 39] = '║';
            fightTemplate[44, 40] = 'H';
            fightTemplate[44, 41] = 'P';
            fightTemplate[44, 42] = ':';
            fightTemplate[44, 46] = '/';
            fightTemplate[44, 50] = '║';
            fightTemplate[44, 51] = 'M';
            fightTemplate[44, 52] = 'P';
            fightTemplate[44, 53] = ':';
            fightTemplate[44, 57] = '/';
            fightTemplate[45, 12] = '╩';
            fightTemplate[45, 13] = '╩';
            fightTemplate[45, 24] = '╩';
            fightTemplate[45, 25] = '╩';
            fightTemplate[45, 38] = '╩';
            fightTemplate[45, 39] = '╩';
            fightTemplate[45, 50] = '╩';
        }
 
    }
}
