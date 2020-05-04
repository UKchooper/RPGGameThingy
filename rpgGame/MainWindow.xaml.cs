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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rpgGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateCharacterButton_Click(object sender, RoutedEventArgs e)
        {
            CharacterUI charWin = new CharacterUI();

            this.Visibility = Visibility.Hidden;
            charWin.Show();
        }
        private void CheckStatsButton_Click(object sender, RoutedEventArgs e)
        {
            CharacterInformation charInfo = new CharacterInformation();

            this.Visibility = Visibility.Hidden;
            charInfo.Show();
        }

        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            FightUI fightPage = new FightUI();

            this.Visibility = Visibility.Hidden;
            fightPage.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void CustomiseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
