using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.BL
{
    public class Items
    {
        public string Name;
        public int HP = 0;
        public int Gold = 0;
        public string Description;

        public Items(string name, int hp, int gold, string description)
        {
            this.Name = name;
            this.HP = hp;
            this.Gold = gold;
            this.Description = description;
        }
    }
}
