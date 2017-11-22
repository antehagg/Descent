using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DataLib.Players;
using Descent.Core;
using Descent.Core.Settings;

namespace Descent.Gui.GameCreation
{
    /// <summary>
    /// Interaction logic for GameCreation.xaml
    /// </summary>
    public partial class PlayerPick : Page
    {
        private GameContext _gc;
        private ObservableCollection<Player> _playerListBoxList;

        public PlayerPick()
        {
        }

        public PlayerPick(GameContext gc)
        {
            InitializeComponent();
            _gc = gc;
            _playerListBoxList = new ObservableCollection<Player>();

            PlayerListBox.DataContext = this;
            PlayerListBox.ItemsSource = _playerListBoxList;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var ai = AiCheckBox.IsChecked != null && (bool) AiCheckBox.IsChecked;
            var name = NameTextBox.Text;

            var newPlayer = new Player
            {
                Id = _gc.PlayerList.Count + 1,
                Ai = ai,
                Name = name
            };

            NameTextBox.Clear();
            AiCheckBox.IsChecked = false;

            var playerAdded = _gc.AddPlayer(newPlayer);
            if(playerAdded)
                _playerListBoxList.Add(newPlayer);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var removePlayer = (Player)PlayerListBox.SelectedItems[0];

            if (removePlayer != null)
            {
                _gc.PlayerList.Remove(removePlayer);
                _playerListBoxList.Remove(removePlayer);
            }
        }
    }
}
