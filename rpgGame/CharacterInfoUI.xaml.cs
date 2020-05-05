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
    /// Interaction logic for CharacterInformation.xaml
    /// </summary>
    public partial class CharacterInformation : UserControl
    {
        public CharacterInformation()
        {
            InitializeComponent();

         //   CharacterImage.Source = new BitmapImage(new Uri($@"C:\Users\carl.hooper\source\repos\rpgGame\rpgGame\Resources\{Character.Name}.png"));

            CharacterDataLbl.Content = Character.Name;
            HPDataLbl.Content = $"{Character.HP} / {Character.HPLimit}";
            AgilityDataLbl.Content = Character.Agility;
            LuckDataLbl.Content = Character.Luck;
            StrengthDataLbl.Content = Character.Strength;
            VitalityDataLbl.Content = Character.Vitality;
            AttackDataLbl.Content = Character.Attack;
            DodgeDataLbl.Content = Character.Dodge;
            XPDataLbl.Content = Character.XP;
            GoldDataLbl.Content = Character.Gold;
            LevelDataLbl.Content = Character.Level;
            PointsDataLbl.Content = Character.StatPoints;

            List<Button> buttonDisabled = new List<Button>
            {
                Agility_PlusButton,
                Agility_MinusButton,
                Luck_PlusButton,
                Luck_MinusButton,
                Strength_PlusButton,
                Strength_MinusButton,
                Vitality_PlusButton,
                Vitality_MinusButton
            };

            if (Character.StatPoints == 0)
            {
                foreach (var button in buttonDisabled)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            this.Visibility = Visibility.Hidden;
            //main.CheckStatsButton.IsEnabled = true;
            //main.CreateCharacterButton.IsEnabled = false;
            //main.FightButton.IsEnabled = true;
            main.Show();
        }

        private void Agility_PlusButton_Click(object sender, RoutedEventArgs e)
        {

            DisableStatsButtons(CharacterStats.AddStat(this.Agility_PlusButton.Name));
            UpdateStats();
        }

        private void Agility_MinusButton_Click(object sender, RoutedEventArgs e)
        {
            DisableStatsButtons(CharacterStats.MinusStat(this.Agility_PlusButton.Name));
            UpdateStats();
        }

        private void Luck_PlusButton_Click(object sender, RoutedEventArgs e)
        {
            DisableStatsButtons(CharacterStats.AddStat(this.Luck_PlusButton.Name));
            UpdateStats();
        }

        private void Strength_PlusButton_Click(object sender, RoutedEventArgs e)
        {
            DisableStatsButtons(CharacterStats.AddStat(this.Strength_PlusButton.Name));
            UpdateStats();
        }

        private void Vitality_PlusButton_Click(object sender, RoutedEventArgs e)
        {
            DisableStatsButtons(CharacterStats.AddStat(this.Vitality_PlusButton.Name));
            UpdateStats();
        }

        private void Luck_MinusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Strength_MinusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vitality_MinusButton_Click(object sender, RoutedEventArgs e)
        {

        }
        public void UpdateStats()
        {
            CharacterDataLbl.Content = Character.Name;
            HPDataLbl.Content = $"{Helpers.MultiplyStats(Character.HPBase, Character.Vitality)} / {Character.HPLimit}";
            AgilityDataLbl.Content = Character.Agility;
            LuckDataLbl.Content = Character.Luck;
            StrengthDataLbl.Content = Character.Strength;
            VitalityDataLbl.Content = Character.Vitality;
            AttackDataLbl.Content = Helpers.MultiplyStats(Character.Attack, Character.Strength); ;
            DodgeDataLbl.Content = Helpers.MultiplyStats(Character.Agility, 2);
            XPDataLbl.Content = Character.XP;
            GoldDataLbl.Content = Character.Gold;
            LevelDataLbl.Content = Character.Level;
            PointsDataLbl.Content = Character.StatPoints;
        }

        public void DisableStatsButtons(bool returned)
        {
            List<Button> buttonDisabled = new List<Button>
            {
                Agility_PlusButton,
                Agility_MinusButton,
                Luck_PlusButton,
                Luck_MinusButton,
                Strength_PlusButton,
                Strength_MinusButton,
                Vitality_PlusButton,
                Vitality_MinusButton
            };

            if (returned == false)
            {
                foreach (var button in buttonDisabled)
                {
                    button.IsEnabled = false;
                }
            }
        }
        public void DisableMinusStatsButtons(bool returned)
        {
            List<Button> buttonDisabled = new List<Button>
            {
                Agility_MinusButton,
                Luck_MinusButton,
                Strength_MinusButton,
                Vitality_MinusButton
            };

            if (returned == false)
            {
                foreach (var button in buttonDisabled)
                {
                    button.IsEnabled = false;
                }
            }
        }
    }
}
