using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG
{
    public class Character
    {
        public string name;
        public double health;
        public double healthMax;
        public int level;
        public int armor;
        public int dodge;
        public int mana;
        public int manaMax;
        public int strength;
        public int constitution;
        public int dexterity;
        public int intelligence;
        public int piety;
        public int resistFire = 0;
        public int resistIce = 0;
        public int resistWind = 0;
        public int resistEarth = 0;
        public int resistLightning = 0;
        public int resistWater = 0;
        public int resistLight = 0;
        public int resistDark = 0;
        public int defenderBuffBonus = 0;
        public int buffDefend = 0;
        public int protectBuffBonus = 0;
        public int buffProtect = 0;
        public int buffFireShield = 0;
        public int buffIceShield = 0;
        public int buffWindShield = 0;
        public int buffEarthShield = 0;
        public int buffLightningShield = 0;
        public int buffWaterShield = 0;
        public string actionString;
        public string responceString;
        Dice dice = new Dice();
        public CharacterClass characterClass = new CharacterClass();
        public List<Item> equipment = new List<Item>();


        public Character()
        {
        }
        public void SelectClass(string ClassName)
        {
            switch(ClassName)
            {
                case "Fighter":
                    characterClass = new Fighter();
                    break;
                case "Wizard":
                    characterClass = new Wizard();
                    break;
                case "Priest":
                    characterClass = new Priest();
                    break;
                case "Ranger":
                    characterClass = new Ranger();
                    break;
            }
        }
        public void InitializeAttributes()
        {
            strength = (characterClass.strengthStart + (characterClass.strengthOnLevel * level));
            armor = (strength / 5);
            constitution = (characterClass.constitutionStart + (characterClass.constitutionOnLevel * level));
            healthMax = constitution;
            health = constitution;
            dexterity = (characterClass.dexterityStart + (characterClass.dexterityOnLevel * level));
            dodge = (dexterity / 5);
            intelligence = (characterClass.intelligenceStart + (characterClass.intelligenceOnLevel * level));
            manaMax = intelligence;
            mana = manaMax;
            piety = (characterClass.pietyStart + (characterClass.pietyOnLevel * level));
            resistFire = (piety / 5);
            resistIce = (piety / 5);
            resistWind = (piety / 5);
            resistEarth = (piety / 5);
            resistLightning = (piety / 5);
            resistWater = (piety / 5);
            resistLight = (piety / 5);
            resistDark = (piety / 5);
        }
        public double Attack()
        {
            double damage = dice.DFour();
            damage += (strength / 5);
            actionString = name + " has Attacked ";
            return damage;
        }
        public void Defend()
        {
            buffDefend = 2;
            defenderBuffBonus = (constitution / 5);
            armor += defenderBuffBonus;
            actionString = name + " has Defended";

        }
        public void RecieveAttack(double Damage, int Element)
        {
            double damageMultiplier = CheckElement(Element);
            double damage = Damage * damageMultiplier;
            double currentArmor = armor;
            if(currentArmor > damage)
            {
                currentArmor = damage;
            }
            damage -= currentArmor;
            health -= damage;
            if(health <= 0)
            {
                health = 0;
            }
            responceString = name + " for " + damage;
        }
        public void RecieveSkill(double Damage, int Element)
        {
            double damageMultiplier = CheckElement(Element);
            double damage = Damage * damageMultiplier;
            double currentArmor = armor;
            if (currentArmor > damage)
            {
                currentArmor = damage;
            }
            damage -= currentArmor;
            health -= damage;
            if (health <= 0)
            {
                health = 0;
            }
            responceString = name + " for " + damage;
        }
        public double CheckElement(int Element)
        {
            double damageMultiplier;
            switch (Element)
            {
                case 1:
                    damageMultiplier = (1 - (.05 * resistFire));
                    break;
                case 2:
                    damageMultiplier = (1 - (.05 * resistIce));
                    break;
                case 3:
                    damageMultiplier = (1 - (.05 * resistWind));
                    break;
                case 4:
                    damageMultiplier = (1 - (.05 * resistEarth));
                    break;
                case 5:
                    damageMultiplier = (1 - (.05 * resistFire));
                    break;
                case 6:
                    damageMultiplier = (1 - (.05 * resistWater));
                    break;
                case 7:
                    damageMultiplier = (1 - (.05 * resistLight));
                    break;
                case 8:
                    damageMultiplier = (1 - (.05 * resistDark));
                    break;
                default:
                    damageMultiplier = 1;
                    break;
            }
            return damageMultiplier;
        }
        public void CheckBuffs()
        {
            CheckDefend();
            CheckProtect();
            CheckMagicShield();
        }
        public void CheckMagicShield()
        {
            CheckFireShield();
            CheckIceShield();
            CheckWindShield();
            CheckEarthShield();
            CheckLightningShield();
            CheckWaterShield();
        }
        public void CheckFireShield()
        {
            if(buffFireShield > 1)
            {
                buffFireShield--;
            }
            if(buffFireShield == 1)
            {
                buffFireShield--;
                resistFire -= 5;
            }
        }
        public void CheckIceShield()
        {
            if (buffIceShield > 1)
            {
                buffIceShield--;
            }
            if (buffIceShield == 1)
            {
                buffIceShield--;
                resistIce -= 5;
            }
        }
        public void CheckWindShield()
        {
            if (buffWindShield > 1)
            {
                buffWindShield--;
            }
            if (buffWindShield == 1)
            {
                buffWindShield--;
                resistWind -= 5;
            }
        }
        public void CheckEarthShield()
        {
            if (buffEarthShield > 1)
            {
                buffEarthShield--;
            }
            if (buffEarthShield == 1)
            {
                buffEarthShield--;
                resistEarth -= 5;
            }
        }
        public void CheckLightningShield()
        {
            if (buffLightningShield > 1)
            {
                buffLightningShield--;
            }
            if (buffLightningShield == 1)
            {
                buffLightningShield--;
                resistLightning -= 5;
            }
        }
        public void CheckWaterShield()
        {
            if (buffWaterShield > 1)
            {
                buffWaterShield--;
            }
            if (buffWaterShield == 1)
            {
                buffWaterShield--;
                resistWater -= 5;
            }
        }
        public void CheckDefend()
        {
            if(buffDefend > 1)
            {
                buffDefend--;
            }
            if(buffDefend == 1)
            {
                buffDefend--;
                armor -= defenderBuffBonus;
            }
        }
        public void CheckProtect()
        {
            if(buffProtect > 1)
            {
                buffProtect--;
            }
            if(buffProtect == 1)
            {
                buffProtect--;
                armor -= protectBuffBonus;
            }
        }

        public void CheckDebuff()
        {
          //CheckStun();
          //CheckBleed();
          //CheckBurn();
        }
        public void IncreaseMana(int ManaGain)
        {
            mana += ManaGain;
        }
        public void DecreaseMana(int ManaLoss)
        {
            mana -= ManaLoss;
        }
        public void RecieveHeal(double HealthGain)
        {
            health += HealthGain;
        }

    }
}
