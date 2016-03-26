using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class AimedShot : Skill

    {
        
        string skillCanTarget;
        int cursorFourStart;



        public AimedShot()
        {
            skillCanTarget = "Enemy";
            cursorFourStart = 5; 
        }
        public virtual void SkillEffect()
        {

        }
    }
}
