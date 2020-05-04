using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame
{
    public class Monster
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        public int Strength { get; set; }
        public int Vitality { get; set; }
        public int BaseHP { get; set; }
        public int XP { get; set; }
        public int Gold { get; set; }

        public Monster(string name, int hp, int agility, int luck, int strength, int vitality, int xp, int gold)
        {
            this.Name = name;
            this.HP = hp;
            this.BaseHP = hp;
            this.Agility = agility;
            this.Luck = luck;
            this.Strength = strength;
            this.Vitality = vitality;
            this.XP = xp;
            this.Gold = gold;
        }

        public void ResetHP()
        {
            this.HP = this.BaseHP;
        }
    }
}
