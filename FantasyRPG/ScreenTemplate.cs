using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class ScreenTemplate
    {
        public char[,] screenTemplate = new char[48,64];

        public ScreenTemplate()
        {
            PopulateTemplate();
            SetCharacters();
        }
        public void PopulateTemplate()
        {
            for (int i = 0; i < 48; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    screenTemplate[i, j] = ' ';
                }
            }
        }
        public void SetCharacters()
        {
            Boarder();
            SetWords();

        }
        public void SetWords()
        {
            SetHP();
            SetMP();
            SetAttributes();
            SetPartyStats();
        }
        public void SetPartyStats()
        {
            screenTemplate[7, 2] = 'G';
            screenTemplate[7, 3] = 'O';
            screenTemplate[7, 4] = 'L';
            screenTemplate[7, 5] = 'D';
            screenTemplate[7, 6] = ':';
            screenTemplate[6, 11] = '╦';
            screenTemplate[7, 11] = '║';
            screenTemplate[8, 11] = '╩';
            screenTemplate[7, 12] = 'L';
            screenTemplate[7, 13] = 'E';
            screenTemplate[7, 14] = 'V';
            screenTemplate[7, 15] = 'E';
            screenTemplate[7, 16] = 'L';
            screenTemplate[7, 17] = ':';
            screenTemplate[6, 21] = '╦';
            screenTemplate[7, 21] = '║';
            screenTemplate[8, 21] = '╩';
            screenTemplate[7, 22] = 'E';
            screenTemplate[7, 23] = 'X';
            screenTemplate[7, 24] = 'P';
            screenTemplate[7, 25] = ':';
            screenTemplate[6, 31] = '╦';
            screenTemplate[7, 31] = '║';
            screenTemplate[8, 31] = '╩';
            screenTemplate[7, 32] = 'L';
            screenTemplate[7, 33] = 'O';
            screenTemplate[7, 34] = 'C';
            screenTemplate[7, 35] = 'A';
            screenTemplate[7, 36] = 'T';
            screenTemplate[7, 37] = 'I';
            screenTemplate[7, 38] = 'O';
            screenTemplate[7, 39] = 'N';
            screenTemplate[7, 40] = ':';
            screenTemplate[6, 49] = '╦';
            screenTemplate[7, 49] = '║';
            screenTemplate[8, 49] = '╩';
            screenTemplate[7, 50] = 'Z';
            screenTemplate[7, 51] = 'O';
            screenTemplate[7, 52] = 'N';
            screenTemplate[7, 53] = 'E';
            screenTemplate[7, 54] = ':';

        }
        public void SetAttributes()
        {
            screenTemplate[2, 38] = 'S';
            screenTemplate[3, 38] = 'S';
            screenTemplate[4, 38] = 'S';
            screenTemplate[5, 38] = 'S';
            screenTemplate[2, 39] = ':';
            screenTemplate[3, 39] = ':';
            screenTemplate[4, 39] = ':';
            screenTemplate[5, 39] = ':';
            screenTemplate[2, 43] = 'C';
            screenTemplate[3, 43] = 'C';
            screenTemplate[4, 43] = 'C';
            screenTemplate[5, 43] = 'C';
            screenTemplate[2, 44] = ':';
            screenTemplate[3, 44] = ':';
            screenTemplate[4, 44] = ':';
            screenTemplate[5, 44] = ':';
            screenTemplate[2, 48] = 'D';
            screenTemplate[3, 48] = 'D';
            screenTemplate[4, 48] = 'D';
            screenTemplate[5, 48] = 'D';
            screenTemplate[2, 49] = ':';
            screenTemplate[3, 49] = ':';
            screenTemplate[4, 49] = ':';
            screenTemplate[5, 49] = ':';
            screenTemplate[2, 53] = 'I';
            screenTemplate[3, 53] = 'I';
            screenTemplate[4, 53] = 'I';
            screenTemplate[5, 53] = 'I';
            screenTemplate[2, 54] = ':';
            screenTemplate[3, 54] = ':';
            screenTemplate[4, 54] = ':';
            screenTemplate[5, 54] = ':';
            screenTemplate[2, 58] = 'P';
            screenTemplate[3, 58] = 'P';
            screenTemplate[4, 58] = 'P';
            screenTemplate[5, 58] = 'P';
            screenTemplate[2, 59] = ':';
            screenTemplate[3, 59] = ':';
            screenTemplate[4, 59] = ':';
            screenTemplate[5, 59] = ':';
        }
    
    
        public void SetMP()
        {
            screenTemplate[2, 29] = 'M';
            screenTemplate[3, 29] = 'M';
            screenTemplate[4, 29] = 'M';
            screenTemplate[5, 29] = 'M';
            screenTemplate[2, 30] = 'P';
            screenTemplate[3, 30] = 'P';
            screenTemplate[4, 30] = 'P';
            screenTemplate[5, 30] = 'P';
            screenTemplate[2, 31] = ':';
            screenTemplate[3, 31] = ':';
            screenTemplate[4, 31] = ':';
            screenTemplate[5, 31] = ':';
            screenTemplate[2, 34] = '/';
            screenTemplate[3, 34] = '/';
            screenTemplate[4, 34] = '/';
            screenTemplate[5, 34] = '/';
        }
        public void SetHP()
        {
            screenTemplate[2, 18] = 'H';
            screenTemplate[3, 18] = 'H';
            screenTemplate[4, 18] = 'H';
            screenTemplate[5, 18] = 'H';
            screenTemplate[2, 19] = 'P';
            screenTemplate[3, 19] = 'P';
            screenTemplate[4, 19] = 'P';
            screenTemplate[5, 19] = 'P';
            screenTemplate[2, 20] = ':';
            screenTemplate[3, 20] = ':';
            screenTemplate[4, 20] = ':';
            screenTemplate[5, 20] = ':';
            screenTemplate[2, 24] = '/';
            screenTemplate[3, 24] = '/';
            screenTemplate[4, 24] = '/';
            screenTemplate[5, 24] = '/';
        }
        public void Boarder()
        {
            Rows();
            Colums();
            Corners();
        }
        public void Corners()
        {
            screenTemplate[0, 0] = '╔';
            screenTemplate[0, 63] = '╗';
            screenTemplate[47, 0] = '╚';
            screenTemplate[47, 1] = '╩';
            screenTemplate[47, 62] = '╩';
            screenTemplate[47, 63] = '╝';
            screenTemplate[1, 1] = '╔';
            screenTemplate[1, 62] = '╗';
            screenTemplate[6, 1] = '╠';
            screenTemplate[6, 62] = '╣';
            screenTemplate[8, 1] = '╠';
            screenTemplate[8, 62] = '╣';
            screenTemplate[45, 0] = '╠';
            screenTemplate[45,63] = '╣';
            screenTemplate[45, 1] = '╬';
            screenTemplate[45, 62] = '╬';
            screenTemplate[46, 1] = '║';
            screenTemplate[46, 62] = '║';
            screenTemplate[1, 9] = '╦';
            screenTemplate[6, 9] = '╩';
            screenTemplate[1, 17] = '╦';
            screenTemplate[6, 17] = '╩';
            screenTemplate[1, 28] = '╦';
            screenTemplate[6, 28] = '╩';
            screenTemplate[1, 37] = '╦';
            screenTemplate[6, 37] = '╩';
            screenTemplate[1, 42] = '╦';
            screenTemplate[6, 42] = '╩';
            screenTemplate[1, 47] = '╦';
            screenTemplate[6, 47] = '╩';
            screenTemplate[1, 52] = '╦';
            screenTemplate[6, 52] = '╩';
            screenTemplate[1, 57] = '╦';
            screenTemplate[6, 57] = '╩';
        }
        public void Rows()
        {
            for (int j = 0; j < 64; j++)
            {
                    screenTemplate[0, j] = '═';
            }
            for (int j = 1; j < 63; j++)
            {
                screenTemplate[1, j] = '═';
            }
            for (int j = 1; j < 63; j++)
            {
                screenTemplate[6, j] = '═';
            }
            for (int j = 1; j < 63; j++)
            {
                screenTemplate[8, j] = '═';
            }
            for (int j = 1; j < 63; j++)
            {
                screenTemplate[45, j] = '═';
            }
 
            for (int j = 0; j < 64; j++)
            {
                screenTemplate[47, j] = '═';
            }
        }
        public void Colums()
        {
            for (int i = 1; i < 47; i++)
            {
                screenTemplate[i, 0] = '║';
            }
            for (int i = 1; i < 47; i++)
            {
                screenTemplate[i, 1] = '║';
            }
            for (int i = 1; i < 47; i++)
            {
                screenTemplate[i, 62] = '║';
            }
            for (int i = 1; i < 47; i++)
            {
                screenTemplate[i, 63] = '║';
            }
            for (int i = 2; i <6; i++)
            {
                screenTemplate[i, 9] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 17] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 28] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 37] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 42] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 47] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 52] = '║';
            }
            for (int i = 2; i < 6; i++)
            {
                screenTemplate[i, 57] = '║';
            }
        }

    }
}
