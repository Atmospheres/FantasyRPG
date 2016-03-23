using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    class Screen
    {
        public ScreenTemplate mainScreen = new ScreenTemplate();
        public ScreenTemplate screenTemplate = new ScreenTemplate();
        public FightScreen fightScreen = new FightScreen();

        public Screen()
        {

        }
        public void PolulateMainPartyInfo(Party MainParty)
        {
            PopulateMainNames(MainParty);
            PopulateMainClass(MainParty);
            PopulateMainStats(MainParty);
            PopulateGold(MainParty);
            PopulateLevel(MainParty);
            PopulateExperience(MainParty);
            Console.Clear();
        }
        public void PopulateExperience(Party MainParty)
        {
            char[] experienceCharArray;
            string experienceString;
            experienceString = MainParty.experience.ToString();
            experienceCharArray = experienceString.ToCharArray();
            for (int experienceArrayIndex = 0; experienceArrayIndex < experienceCharArray.Count(); experienceArrayIndex++)
            {
                screenTemplate.screenTemplate[7, (experienceArrayIndex + 26)] = experienceCharArray[experienceArrayIndex];
            }
        }
        public void PopulateLevel(Party MainParty)
        {
            char[] levelCharArray;
            string levelString;
            levelString = MainParty.level.ToString();
            levelCharArray = levelString.ToCharArray();
            for (int levelArrayIndex = 0; levelArrayIndex < levelCharArray.Count(); levelArrayIndex++)
            {
                screenTemplate.screenTemplate[7, (levelArrayIndex + 18)] = levelCharArray[levelArrayIndex];
            }
        }
        public void PopulateGold(Party MainParty)
        {
            char[] goldCharArray;
            string goldString;
            goldString = MainParty.gold.ToString();
            goldCharArray = goldString.ToCharArray();
            for (int goldArrayIndex = 0; goldArrayIndex < goldCharArray.Count(); goldArrayIndex++)
            {
                screenTemplate.screenTemplate[7, (goldArrayIndex + 7)] = goldCharArray[goldArrayIndex];
            }
        }
        public void PopulateMainStats(Party MainParty)
        {
            PopulateMainHealth(MainParty);
            PopulateMainMana(MainParty);
            PopulateMainStrength(MainParty);
            PopulateMainConstitution(MainParty);
            PopulateMainDexterity(MainParty);
            PopulateMainIntelligence(MainParty);
            PopulateMainPiety(MainParty);
        }
        public void PopulateMainPiety(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] pietyCharArray;
                string pietyString;
                pietyString = MainParty.characterList[characterListIndex].piety.ToString();
                pietyCharArray = pietyString.ToCharArray();
                for (int pietyArrayIndex = 0; pietyArrayIndex < pietyCharArray.Count(); pietyArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (pietyArrayIndex + 60)] = pietyCharArray[pietyArrayIndex];
                }
            }
        }
        public void PopulateMainIntelligence(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] intelligenceCharArray;
                string intelligenceString;
                intelligenceString = MainParty.characterList[characterListIndex].intelligence.ToString();
                intelligenceCharArray = intelligenceString.ToCharArray();
                for (int intelligenceArrayIndex = 0; intelligenceArrayIndex < intelligenceCharArray.Count(); intelligenceArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (intelligenceArrayIndex + 55)] = intelligenceCharArray[intelligenceArrayIndex];
                }
            }
        }
        public void PopulateMainDexterity(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] dexterityCharArray;
                string dexterityString;
                dexterityString = MainParty.characterList[characterListIndex].dexterity.ToString();
                dexterityCharArray = dexterityString.ToCharArray();
                for (int constitutionArrayIndex = 0; constitutionArrayIndex < dexterityCharArray.Count(); constitutionArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (constitutionArrayIndex + 50)] = dexterityCharArray[constitutionArrayIndex];
                }
            }
        }
        public void PopulateMainConstitution(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] constitutionCharArray;
                string constitutionString;
                constitutionString = MainParty.characterList[characterListIndex].constitution.ToString();
                constitutionCharArray = constitutionString.ToCharArray();
                for (int constitutionArrayIndex = 0; constitutionArrayIndex < constitutionCharArray.Count(); constitutionArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (constitutionArrayIndex + 45)] = constitutionCharArray[constitutionArrayIndex];
                }
            }
        }
        public void PopulateMainStrength(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] strengthCharArray;
                string strengthString;
                strengthString = MainParty.characterList[characterListIndex].strength.ToString();
                strengthCharArray = strengthString.ToCharArray();
                for (int strengthArrayIndex = 0; strengthArrayIndex < strengthCharArray.Count(); strengthArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (strengthArrayIndex + 40)] = strengthCharArray[strengthArrayIndex];
                }
            }
        }
        public void PopulateMainHealth(Party MainParty)
        {
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
                    screenTemplate.screenTemplate[(characterListIndex + 2), (healthArrayIndex + 21)] = healthCharArray[healthArrayIndex];
                }
                for (int healthMaxArrayIndex = 0; healthMaxArrayIndex < healthMaxCharArray.Count(); healthMaxArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (healthMaxArrayIndex + 25)] = healthMaxCharArray[healthMaxArrayIndex];
                }
            }
        }
        public void PopulateMainMana(Party MainParty)
        {
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
                    screenTemplate.screenTemplate[(characterListIndex + 2), (manaArrayIndex + 32)] = manaCharArray[manaArrayIndex];
                }
                for (int manaMaxArrayIndex = 0; manaMaxArrayIndex < manaMaxCharArray.Count(); manaMaxArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (manaMaxArrayIndex + 35)] = manaMaxCharArray[manaMaxArrayIndex];
                }
            }
        }
        public void PopulateMainClass(Party MainParty)
        {
            for (int characterListIndex = 0; characterListIndex < MainParty.characterList.Count(); characterListIndex++)
            {
                char[] classCharArray;
                classCharArray = MainParty.characterList[characterListIndex].characterClass.className.ToCharArray();
                for (int classArrayIndex = 0; classArrayIndex < classCharArray.Count(); classArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (classArrayIndex + 10)] = classCharArray[classArrayIndex];
                }
            }
        }
        public void PopulateMainNames(Party MainParty)
        {
            for(int characterListIndex = 0; characterListIndex<MainParty.characterList.Count(); characterListIndex++)
            {
                char[] nameCharArray;
                nameCharArray = MainParty.characterList[characterListIndex].name.ToCharArray();
                for(int nameArrayIndex = 0; nameArrayIndex<nameCharArray.Count(); nameArrayIndex++)
                {
                    screenTemplate.screenTemplate[(characterListIndex + 2), (nameArrayIndex + 2)] = nameCharArray[nameArrayIndex];
                }
            }
        }
        public void PassBattleInfo(Party MainParty, Party EnemyParty)
        {
          //  fightScreen;
        }
    }
}
