using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
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
using DataLib;
using DataLib.Characters;
using DataLib.Players;
using Descent.Core.GameEngine.Fighting;
using Descent.Core.GameEngine.Random;
using Descent.Core.Settings;

namespace Descent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestObjects _testObjects;
        private readonly RandomDice _diceRoller;
        private readonly ApplicationSettings _appSettings;

        private Player _playerOne;

        public MainWindow()
        {
            _appSettings = new ApplicationSettings();
            _diceRoller = new RandomDice();
            InitializeComponent();
        }

        private void CreateTestObjects()
        {
            _testObjects = new TestObjects();

            _playerOne = new HeroPlayer
            {
                Name = "Vexing",
                Ai = false,
                Heroes = new List<Hero>
                {
                    _testObjects.Warrior
                }
            };
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            CreateTestObjects();
        }
    }
}
