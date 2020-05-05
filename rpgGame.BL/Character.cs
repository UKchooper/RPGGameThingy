using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace rpgGame.BL
{
    public class Character
    {
        public static string Name { get; set; }
        public static int HP { get; set; }
        public static int Attack { get; set; }
        public static int Agility { get; set; }
        public static int Luck { get; set; }
        public static int Strength { get; set; }
        public static int Vitality { get; set; }
        public static int HPLimit { get; set; }
        public static int HPBase { get; set; }
        public static int Dodge { get; set; }
        public static int XP { get; set; }
        public static int XPBaseLevel { get; set; }
        public static int Gold { get; set; }
        public static int Level { get; set; }
        public static int StatPoints { get; set; }

        // Items
        public static int WeakPotionCount = 0;
        public static int MediumPotionCount = 0;
        public static int StrongPotionCount = 0;

        public int[] itemsAvailable = new int[] { 0, 0, 0 };

        private Items[] itemHP = new Items[3]
        {
            new Items("Weak Health potion", 25, 5, "Description: This item heals 25 of your Health Points"),
            new Items("Medium Health potion", 50, 10, "Description: This item heals 50 of your Health Points"),
            new Items("Strong Health potion", 75, 15, "Description: This item heals 75 of your Health Points")
        };

        CharacterStats[] characterData = new CharacterStats[]
        {
            new CharacterStats("Archer", 100, 5, 4, 1, 2, 1),
            new CharacterStats("Mage", 100, 5, 1, 1, 1, 5),
            new CharacterStats("Warrior", 100, 5, 2, 1, 4, 1)
        };
        public string AddDescription(string selectedName)
        {
            switch (selectedName)
            {
                case "Archer":
                    return $"You have selected the {selectedName}. His range attacks are powerful!";
                    
                case "Mage":
                    return $"You have selected the {selectedName}. His magical attacks are powerful!";
                    
                case "Warrior":
                    return $"You have selected the {selectedName}. His melee attacks are powerful!";
                   
                default:
                    return $"That's not a character!";
            }
        }
        public string ConfirmSelect(string selectedName) => $"Are you sure you want the {selectedName}?";

        public void AddCharacterStats(string selectedName)
        {
            var characterArray = new[] { "Archer", "Mage", "Warrior" };

            var stats = characterData[Array.IndexOf(characterArray, selectedName)];

            Name = stats.Name;
            Agility = stats.Agility;
            Luck = stats.Luck;
            Strength = stats.Strength;
            Vitality = stats.Vitality;
            HPBase = HP;

            Attack = Helpers.MultiplyStats(stats.Attack,stats.Strength);
            HP = Helpers.MultiplyStats(stats.HP, stats.Vitality);
            Dodge = Helpers.MultiplyStats(stats.Agility, 2);
            HPLimit = HP;
            
            Level = 1;
            StatPoints = 5;
            XP = 0;
            XPBaseLevel = 250;
        }
    }
}
