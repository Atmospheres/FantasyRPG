using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class FightScreen
    {
        int cursorSectionOne = 1;
        int cursorSectionTwo = 1;
        int cursorSectionThree = 1;
        int cursorSectionFour = 1;
        public char[,] fightTemplate = new char[48, 64];

        public void MoveCursorOne()
        { 
        }
        public void MoveCursorTwo()
        {

        }
        public void MoveCursorThree()
        {

        }
        public void MoveCursorFour()

        {

        }
        // basic print
        /* public void PrintFightScreen()
         {
             //top
             for (int i = 0; i < 48; i++)
             {
                 for (int j = 0; j < 64; j++)
                 {
                     Console.Write(fightTemplate[i, j]);
                 }
                 Console.WriteLine();
             }
             for(int i = )

         } */
        public void PrintFightScreen()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }
            //row 11
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



            // row 12
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



            //row 13
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




            //row 14
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



            //row 15
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



            //row 16
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



            //row 17
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

            //row 18-19
            for (int row = 18; row < 20; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }
            //row 20
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
            //row 21
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
            //row 22
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
            //row 23
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
            //row 24
            Console.Write(fightTemplate[23, 0]);
            Console.Write(fightTemplate[23, 1]);

            if (cursorSectionThree == 5)
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
            //row 25
            Console.Write(fightTemplate[24, 0]);
            Console.Write(fightTemplate[24, 1]);

            if (cursorSectionThree == 6)
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
            //row 26
            Console.Write(fightTemplate[25, 0]);
            Console.Write(fightTemplate[25, 1]);

            if (cursorSectionThree == 7)
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
            //row 27-41
            for (int row = 27; row < 41; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }
            //row 42 action
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
            //row 42 name
            if (cursorSectionFour == 1)
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
            //row 42 enemyName
            if (cursorSectionFour == 5)
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
            //finish row 42
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[41, col]);
            }
            Console.WriteLine();

            //row 43 action
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
            //row 43 name
            if (cursorSectionFour == 2)
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
            //row 43 enemyName
            if (cursorSectionFour == 6)
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
            //finish row 43
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[42, col]);
            }
            Console.WriteLine();



            //row 44 action
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
            //row 44 name
            if (cursorSectionFour == 3)
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
            //row 44 enemyName
            if (cursorSectionFour == 7)
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
            //finish row 44
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[43, col]);
            }
            Console.WriteLine();

            //row 45 action
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
            //row 45 name
            if (cursorSectionFour == 4)
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
            //row 45 enemyName
            if (cursorSectionFour == 8)
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
            //finish row 45
            for (int col = 38; col < 64; col++)
            {
                Console.Write(fightTemplate[44, col]);
            }
            Console.WriteLine();

            //row 46-48
            for (int row = 45; row < 48; row++)
            {
                for (int col = 0; col < 64; col++)
                {
                    Console.Write(fightTemplate[row, col]);
                }
                Console.WriteLine();
            }

        }
        public void PopulateFightScreen(ScreenTemplate Template)
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
        public void PopulateSubNames(Party MainParty)
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
        public void AddFightElements()
        {
            AddFightOptions();
            AddCombatLog();
            AddSideContainers();
            AddBottomContainer();
        }
        public void AddEnemyInfo(Party EnemyParty)
        {
            PopulateEnemyNames(EnemyParty);
            PopulateEnemyHealth(EnemyParty);
            PopulateEnemyMana(EnemyParty);
        }

        public void PopulateEnemyNames(Party EnemyParty)
        {
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
        public void PopulateEnemyHealth(Party EnemyParty)
        {
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
        public void PopulateEnemyMana(Party EnemyParty)
        {
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
        public void AddSideContainers()
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
        public void AddCombatLog()
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
        public void AddFightOptions()
        {
                fightTemplate[41, 2] = 'F';
                fightTemplate[41, 3] = 'I';
                fightTemplate[41, 4] = 'G';
                fightTemplate[41, 5] = 'H';
                fightTemplate[41, 6] = 'T';
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
        public void AddBottomContainer()
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
