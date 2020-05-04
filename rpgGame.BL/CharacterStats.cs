using rpgGame.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame
{
    public class CharacterStats
    {
        public string Name;
        public int HP;
        public int Attack;
        public int Agility;
        public int Vitality;
        public int Strength;
        public int Luck;

        
        public CharacterStats(string name, int hp, int attack, int agility, int luck, int strength, int vitality)
        {
            this.Name = name;
            this.HP = hp;
            this.Attack = attack;
            this.Agility = agility;
            this.Vitality = vitality;
            this.Strength = strength;
            this.Luck = luck;
        }

        public static bool buttonsEnabled = true;
        public static bool AddStat(string stat)
        {
            if(stat.Contains("Agility"))
            {
                Character.Agility += 1;
            }
            else if (stat.Contains("Luck"))
            {
                Character.Luck += 1;
            }
            else if (stat.Contains("Strength"))
            {
                Character.Strength += 1;
            }
            else
            {
                Character.Vitality += 1;
            }

            Character.StatPoints -= 1;

            if(Character.StatPoints == 0)
            {
                return buttonsEnabled = false;
            }
            return buttonsEnabled;
        }

        public static bool MinusStat(string stat)
        {

            if (stat.Contains("Agility"))
            {
                Character.Agility -= 1;
            }
            else if (stat.Contains("Luck"))
            {
                Character.Luck -= 1;
            }
            else if (stat.Contains("Strength"))
            {
                Character.Strength -= 1;
            }
            else
            {
                Character.Vitality -= 1;
            }

            Character.StatPoints += 1;

            if (Character.StatPoints == 0)
            {
                return buttonsEnabled = false;
            }
            return buttonsEnabled;
        }
    }
}