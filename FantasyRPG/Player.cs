using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Player : Character
    {
        CharacterClass Class = new CharacterClass();
        public Player(string Name)
        {
            name = Name;
        }

    }
}
