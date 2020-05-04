using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.BL
{
    public class Fight
    {
        public static int XpBonus { get; set; }
        public static int GoldBonus { get; set; }

        public static int P1Dice { get; set; }

        public static int MonsterDice { get; set; }

        public static int DodgeChance { get; set; }

        public static int MonsterHP { get; set; }
        public static string MonsterName { get; set; }

        public static int BaseMonsterHP { get; set; }
        public static int MonsterXP { get; set; }
        public static int MonsterGold { get; set; }

        public static Monster CurrentMonster;

        static List<Monster> monsters = new List<Monster>();

        static Monster monster1 = new Monster("Weakest Monster", 25, 1, 1, 1, 2, 100, 5);
        static Monster monster2 = new Monster("Weak Monster", 50, 2, 2, 2, 3, 200, 10);
        public static Monster ChooseMonsterDifficulty(int lower, int higher)
        {
            return CurrentMonster = monsters[Helpers.RandNumber(lower, higher)];
        }

        public static void AddMonsterToBattle()
        {
            MonsterHP = CurrentMonster.HP;
            MonsterName = CurrentMonster.Name;
            MonsterXP = CurrentMonster.XP;
            MonsterGold = CurrentMonster.Gold;

        }

        public static bool LevelUp(int fightXP)
        {
            if (fightXP >= Character.XPBaseLevel)
            {
                Character.Level++;
                Character.XPBaseLevel += // Convert.ToInt32(Character.XPBaseLevel * 1.25);
                Character.XP = 0;
                Character.StatPoints += 1;

                return true;
            }

            return false;
        }

        public static bool PlayerWinner(int MonsterXP, int MonsterGold)
        {
            if (Character.Luck > Helpers.RandNumber(0, 5))
            {
                XpBonus = Convert.ToInt32(MonsterXP * 1.10);
                GoldBonus = Convert.ToInt32(MonsterGold * 1.10);
                Character.XP += XpBonus;
                Character.Gold += GoldBonus;
            
                return true;
            }
            else
            {
                Character.XP += MonsterXP;
                Character.Gold += MonsterGold;

                return false;
            }
        }
        public static string WhoIsWinner(int MonsterHP)
        {
            if (Character.HP > MonsterHP)
            {
                return "Player";
            }
            else if (MonsterHP > Character.HP)
            {
                return "Computer";
            }
            else
            {
                return "NoWinner";
            }
        }

        public static string RoundWinner(int monsterHP, int p1Dice, int monsterDice, int dodgeChance)
        {
            MonsterHP = monsterHP;
            P1Dice = p1Dice;
            MonsterDice = monsterDice;
            DodgeChance = dodgeChance;

            if (p1Dice > monsterDice)
            {
                if (Character.Dodge > dodgeChance)
                {
                    // FightLogTextBlock.Text += $"Player 1 dodges {CurrentMonster.Name} attack. Dodge stats: Player 1 {Character.Dodge} is higher than {dodgeChance}\n";
                    return "WinDodgeSuccess";
                }
                else
                {
                    MonsterHP -= Character.Attack;
                    if (MonsterHP < 0)
                    {
                        MonsterHP = 0;
                    }
                }

                return "WinDodgeFail";
                // FightLogTextBlock.Text += $"Player 1 winner with dice roll of {p1Dice} - {this.CurrentMonster.Name} HP is: {this.CurrentMonster.HP} / {MonsterHPLimit}\n\n";

            }
            else if (p1Dice == monsterDice)
            {
                Character.HP -= (10 / 2);
                MonsterHP -= (Character.Attack / 2);
                if (Character.HP < 0)
                {
                    Character.HP = 0;
                }

                else if (MonsterHP < 0)
                {
                    MonsterHP = 0;
                }

                return "BothHit";
                // FightLogTextBlock.Text += $"Both dice match dice: {p1Dice} - {CurrentMonster.Name} HP is: {CurrentMonster.HP} / {MonsterHPLimit} - Player 1 HP is: {Character.HP} / {Character.HPLimit}\n\n";
            }
            else
            {
                Character.HP -= 10;

                if (Character.HP < 0)
                {
                    Character.HP = 0;
                }

                return "Lose";
                // FightLogTextBlock.Text += $"{CurrentMonster.Name} winner with dice roll of {monsterDice} - Player 1 HP is: {Character.HP} / {Character.HPLimit}\n\n";
            }
        }

        public static void MonsterResetHP()
        {
            MonsterHP = BaseMonsterHP;
        }
        public static void AddMonsters()
        {
            monsters.Add(monster1);
            monsters.Add(monster2);
            /* 
             * 
            disabled to make testing easier
            
            monsters.Add(monster3);
            monsters.Add(monster4);
            monsters.Add(monster5);
            */
        }
    }
}
