using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class Party
    {
        public int gold;
        public int level;
        public int experience;
        public List<Character> characterList = new List<Character>();
        public List<string> inventory = new List<string>();
        public Party()
        { 
        }

        public void SetupParty()
        {
            for (int index = 0; index < 4; index++)
            {
                string name = GetName();
                string playerClass = SelectClass();
                Player player = new Player(name);
                characterList.Add(player);
                characterList[index].SelectClass(playerClass);
                characterList[index].InitializeAttributes();
            }
            level = 1;
            experience = 0;
            gold = 10;
        }
        public string GetName()
        {
            Console.WriteLine("Please Enter a Name");
            string name = Console.ReadLine();
            return name;
        }
        public string SelectClass()
        {
            
            Console.WriteLine("Please Select a class");
            Console.WriteLine("1: Fighter");
            Console.WriteLine("2: Wizard");
            Console.WriteLine("3: Priest");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            string classChoice;
            switch (inputInt)
            {
                case 1:
                    classChoice = "Fighter";
                    break;
                case 2:
                    classChoice = "Wizard";
                    break;
                case 3:
                    classChoice = "Priest";
                    break;
                default:
                    classChoice = "Fighter";
                    break;
            }
            return classChoice;
        }
    }
}
