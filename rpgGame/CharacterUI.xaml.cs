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
    /// Interaction logic for Character.xaml
    /// </summary>
    public partial class CharacterUI : UserControl
    {
        Character charInfo = new Character();

        public string selectedName;

        public CharacterUI()
        {
            InitializeComponent();

        }
        void ShowCharacterStats()
        {
            CharacterDataLbl.Content = Character.Name;
            HPDataLbl.Content = Character.HP;
            AgilityDataLbl.Content = Character.Agility;
            LuckDataLbl.Content = Character.Luck;
            StrengthDataLbl.Content = Character.Strength;
            VitalityDataLbl.Content = Character.Vitality;
        }
        private void ArcherButton_Click(object sender, RoutedEventArgs e)
        {
            //selectedName = ArcherButton.Content.ToString();
            //EnableDisableButton();
            DescriptionTextBlock.Text = charInfo.AddDescription(selectedName);
            ConfirmCharButton.IsEnabled = true;
            ConfirmSelectionText.Content = charInfo.ConfirmSelect(selectedName);
            charInfo.AddCharacterStats(selectedName);
            ShowCharacterStats();
        }

        private void MageButton_Click(object sender, RoutedEventArgs e)
        {
            selectedName = MageButton.Content.ToString();
            //EnableDisableButton();
            DescriptionTextBlock.Text = charInfo.AddDescription(selectedName);
            ConfirmCharButton.IsEnabled = true;
            ConfirmSelectionText.Content = charInfo.ConfirmSelect(selectedName);
            charInfo.AddCharacterStats(selectedName);
            ShowCharacterStats();
        }

        private void WarriorButton_Click(object sender, RoutedEventArgs e)
        {
            selectedName = WarriorButton.Content.ToString();
            //EnableDisableButton();
            DescriptionTextBlock.Text = charInfo.AddDescription(selectedName);
            ConfirmCharButton.IsEnabled = true;
            ConfirmSelectionText.Content = charInfo.ConfirmSelect(selectedName);
            charInfo.AddCharacterStats(selectedName);
            ShowCharacterStats();
        }
        private void ConfirmCharButton_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow main = new MainWindow();

            //this.Visibility = Visibility.Hidden;
            //main.CreateCharacterButton.IsEnabled = false;
            //main.CheckStatsButton.IsEnabled = true;
            //main.FightButton.IsEnabled = true;
            //main.Show();
        }

        //public void EnableDisableButton()
        //{
        //    var characterNameArray = new[] { ArcherButton, MageButton, WarriorButton };

        //    foreach (var charName in characterNameArray)
        //    {
        //        if (charName.IsMouseOver ? charName.IsEnabled = false : charName.IsEnabled = true);
        //    }
        //}

        private void ConfirmSelection_MouseDown(object sender, MouseButtonEventArgs e)
        {


        }
    }
}