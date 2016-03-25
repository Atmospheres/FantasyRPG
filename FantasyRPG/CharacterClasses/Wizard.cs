using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Wizard : CharacterClass
 {

        public Wizard()
        {
            className = "Wizard";
            strengthStart = 5;
            strengthOnLevel = 1;
            constitutionStart = 15;
            constitutionOnLevel = 3;
            dexterityStart = 5;
            dexterityOnLevel = 1;
            intelligenceStart = 20;
            intelligenceOnLevel = 4;
            pietyStart = 15;
            pietyOnLevel = 3;
            KnownSkillList.Add("M. Bolt");
            KnownSkillList.Add("M. Shield");
            KnownSkillList.Add("Drain");
            KnownSkillList.Add("Aspir");
            KnownSkillList.Add("Meditate");
        }

        public override void MoveOneOptions()
        {
            ClearSubSkillList();
            subSkillList.Add("Fire");
            subSkillList.Add("Ice");
            subSkillList.Add("Wind");
            subSkillList.Add("Earth");
            subSkillList.Add("Lightning");
            subSkillList.Add("Water");
        }

        public override void MoveTwoOptions()
        {
            ClearSubSkillList();
            subSkillList.Add("Fire");
            subSkillList.Add("Ice");
            subSkillList.Add("Wind");
            subSkillList.Add("Earth");
            subSkillList.Add("Lightning");
            subSkillList.Add("Water");
        }

        public override void MoveThreeOptions()
        {
            ClearSubSkillList();
        }
        public override void MoveFourOptions()
        {
            ClearSubSkillList();
        }
        public override void MoveFiveOptions()
        {
            ClearSubSkillList();
        }
        public override void MoveSixOptions()
        {
            ClearSubSkillList();
        }
        public override void MoveSevenOptions()
        {
            ClearSubSkillList();
        }
    }
}
