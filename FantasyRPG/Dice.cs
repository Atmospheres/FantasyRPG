using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Dice
    {
        Random rnd = new Random();
        public int DFour()
        {
            int dFour = rnd.Next(1, 5);
            return dFour;
        }
        public int DSix()
        {
            int dSix = rnd.Next(1, 7);
            return dSix;
        }
        public int DEight()
        {
            int dEight = rnd.Next(1, 9);
            return dEight;
        }
        public int DTen()
        {
            int dTen = rnd.Next(1, 11);
            return dTen;
        }
        public int DTwelve()
        {
            int dTwelve = rnd.Next(1, 13);
            return dTwelve;
        }
        public int DTwenty()
        {
            int dTwenty = rnd.Next(1, 21);
            return dTwenty;
        }
    }
}
