using rpgGame.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace rpgGame
{
    /// <summary>
    /// Interaction logic for Fight.xaml
    /// </summary>
    public partial class FightUI : UserControl
    {
        public FightUI()
        {
            InitializeComponent();
        }

        List<Monster> monsters = new List<Monster>();

        Monster monster1 = new Monster("Weakest Monster", 25, 1, 1, 1, 2, 100, 5);
        Monster monster2 = new Monster("Weak Monster", 50, 2, 2, 2, 3, 200, 10);
        /*
        Monster monster3 = new Monster("Medium Monster", 75, 3, 3, 3, 4, 300, 15);
        Monster monster4 = new Monster("Hard Monster", 100, 4, 4, 4, 5, 400, 20);
        Monster monster5 = new Monster("Very hard Monster", 125, 5, 5, 5, 6, 500, 25);
        */
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            this.Visibility = Visibility.Hidden;
            //main.CheckStatsButton.IsEnabled = true;
            //main.CreateCharacterButton.IsEnabled = false;
            //main.FightButton.IsEnabled = true;
            main.Show();
        }
        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            FightLogTextBlock.Text = string.Empty;
            Battle();
        }
        private void StatsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowCurrentStats();
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            // do code for shop
        }

        //public Monster CurrentMonster;

        public Fight battle;

        public Character Player;

        void Battle()
        {
            Fight.AddMonsters();
            Fight.ChooseMonsterDifficulty(0, 1);
            Fight.MonsterResetHP();
            Fight.AddMonsterToBattle();

            int stageNumber = 0;

            int MonsterHPLimit = Fight.MonsterHP;

         //   FightLogTextBlock.Text = $"Battle:\n{Character.Name} vs {Fight.MonsterName}\n\n";

            while ((Character.HP > 0) && (Fight.MonsterHP > 0))
            {
                int p1Dice = Helpers.RandNumber(1, 7);
                int monsterDice = Helpers.RandNumber(1, 7);

                stageNumber++;

                FightLogTextBlock.Text += $"Stage {stageNumber}:\n";
                FightLogTextBlock.Text += $"Player 1 rolled a {p1Dice}\n";
                FightLogTextBlock.Text += $"{Fight.MonsterName} rolled a {monsterDice}\n\n";

                int dodgeChance = Helpers.RandNumber(1, 50);

                RoundWinnerText(Fight.RoundWinner(Fight.MonsterHP, p1Dice, monsterDice, dodgeChance), MonsterHPLimit);

                /*
                if (p1Dice > monsterDice)
                {
                    if (Character.Dodge > dodgeChance)
                    {
                        FightLogTextBlock.Text += $"Player 1 dodges {CurrentMonster.Name} attack. Dodge stats: Player 1 {Character.Dodge} is higher than {dodgeChance}\n";
                    }
                    else
                    {
                        CurrentMonster.HP -= Character.Attack;
                        if (CurrentMonster.HP < 0)
                        {
                            CurrentMonster.HP = 0;
                        }
                    }

                    FightLogTextBlock.Text += $"Player 1 winner with dice roll of {p1Dice} - {this.CurrentMonster.Name} HP is: {this.CurrentMonster.HP} / {MonsterHPLimit}\n\n";

                }
                else if (p1Dice == monsterDice)
                {
                    Character.HP -= (10 / 2);
                    this.CurrentMonster.HP -= (Character.Attack / 2);
                    if (Character.HP < 0)
                    {
                        Character.HP = 0;
                    }

                    else if (this.CurrentMonster.HP < 0)
                    {
                        this.CurrentMonster.HP = 0;
                    }

                    FightLogTextBlock.Text += $"Both dice match dice: {p1Dice} - {CurrentMonster.Name} HP is: {CurrentMonster.HP} / {MonsterHPLimit} - Player 1 HP is: {Character.HP} / {Character.HPLimit}\n\n";
                }
                else
                {
                    Character.HP -= 10;

                    if (Character.HP < 0)
                    {
                        Character.HP = 0;
                    }

                    FightLogTextBlock.Text += $"{CurrentMonster.Name} winner with dice roll of {monsterDice} - Player 1 HP is: {Character.HP} / {Character.HPLimit}\n\n";
                }
                */

                // if (ReadConfig.currentGameSpeed == "slow")
                // {
                //     Console.WriteLine(Continue);
                //     Console.ReadLine();
                // }
            }

            WinnerText(Fight.WhoIsWinner(Fight.MonsterHP));

        }

        //public Monster chooseMonsterDifficulty(int lower, int higher)
        //{
        //   return CurrentMonster = monsters[Helpers.RandNumber(lower, higher)];
        //}
        public void AddMonsters()
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

        private void CreateMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            Monster monster6 = new Monster("Custom Monster", 125, 5, 5, 5, 6, 500, 25);

            monsters.Add(monster6);
        }

        public void ShowCurrentStats()
        {
            FightLogTextBlock.Text = $"Level is: {Character.Level}";
            FightLogTextBlock.Text += $"\nAgility is: {Character.Agility}";
            FightLogTextBlock.Text += $"\nStrength is: {Character.Strength}";
            FightLogTextBlock.Text += $"\nVitality is: {Character.Vitality}";
            FightLogTextBlock.Text += $"\nLuck is: {Character.Luck}";
            FightLogTextBlock.Text += $"\nHP is: {Character.HP} / {Character.HPLimit}";
            FightLogTextBlock.Text += $"\nAttack is: {Character.Attack}";
            FightLogTextBlock.Text += $"\nDodge is: {Character.Dodge}";
            FightLogTextBlock.Text += $"\nXP is: {Character.XP} / {Character.XPBaseLevel}";
            FightLogTextBlock.Text += $"\nGold is: {Character.Gold}";
            FightLogTextBlock.Text += "\n\nItems:";
            FightLogTextBlock.Text += $"\nWeak HP: {Character.WeakPotionCount}";
            FightLogTextBlock.Text += $"\nMedium HP: {Character.MediumPotionCount}";
            FightLogTextBlock.Text += $"\nStrong HP: {Character.StrongPotionCount}";
        }

        public void LevelUpText(bool returned)
        {
            if (returned)
            {
                FightLogTextBlock.Text += $"You have reached Level: {Character.Level}!!\n";
                FightLogTextBlock.Text += $"{Character.StatPoints} stat points added!\n\n";
            }
        }

        public void WinnerLuckText(bool returned)
        {
            if (returned)
            {
                FightLogTextBlock.Text += "Your Luck is in! 10% bonus to XP and Gold!\n";
                FightLogTextBlock.Text += $"You have gained: {Fight.XpBonus} XP & {Fight.GoldBonus} Gold\n\n";
            }
            else
            {
                FightLogTextBlock.Text += $"You have gained: {Fight.MonsterXP} XP & {Fight.MonsterGold} Gold\n\n";
            }   
        }

        public void WinnerText(string winner)
        {
            if (winner == "Player")
            {
                WinnerLuckText(Fight.PlayerWinner(Fight.MonsterXP, Fight.MonsterGold));
                LevelUpText(Fight.LevelUp(Character.XP));
                FightLogTextBlock.Text += $"Battle over - Winner is Player 1 with {Character.HP} / {Character.HPLimit} HP";
            }
            else if (winner == "Computer")
            {
                FightLogTextBlock.Text += $"Overall winner is {Fight.MonsterName} with {Fight.MonsterHP} HP\n";
            }
            else
            {
                FightLogTextBlock.Text += $"DRAW! Both players got {Character.HP} / {Character.HPLimit} HP\n\n";
            }

        }

        public void RoundWinnerText(string roundWinner, int MonsterHPLimit)
        {
            if (roundWinner == "WinDodgeSuccess")
            {
                FightLogTextBlock.Text += $"Player 1 dodges {Fight.MonsterName} attack. Dodge stats: Player 1 {Character.Dodge} is higher than {Fight.DodgeChance}\n";
            }
            else if (roundWinner == "WinDodgeFail")
            {
                FightLogTextBlock.Text += $"Player 1 winner with dice roll of {Fight.P1Dice} - {Fight.MonsterName} HP is: {Fight.MonsterHP} / {MonsterHPLimit}\n\n";
            }
            else if (roundWinner == "BothHit")
            {
                FightLogTextBlock.Text += $"Both dice match dice: {Fight.P1Dice} - {Fight.MonsterName} HP is: {Fight.MonsterHP} / {MonsterHPLimit} - Player 1 HP is: {Character.HP} / {Character.HPLimit}\n\n";
            }
            else
            {
                FightLogTextBlock.Text += $"{Fight.MonsterName} winner with dice roll of {Fight.MonsterDice} - Player 1 HP is: {Character.HP} / {Character.HPLimit}\n\n";
            }
        }
    }
}