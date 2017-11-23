using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DataLib.Abilities;
using DataLib.Characters.HeroData;
using DataLib.Contexts;
using Descent.Core;
using Descent.Core.GameEngine.Random;
using Descent.Gui.Editor;
using Descent.Gui.GameCreation;
using Descent.Gui.GameState;

namespace Descent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private State _gameState;
        private ObservableCollection<Button> _menuCollection;

        public MainWindow()
        {
            InitializeComponent();

            _menuCollection = new ObservableCollection<Button>();
            _gameState = new State {Type = StateType.Init};
            LoadInitMenu();
        }

        private void LoadEditMenu()
        {
            var abilityButton = new Button
            {
                Name = "AbilityButton",
                Content = "Ability",
                Width = 100,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10, 0, 0, 0)
            };

            abilityButton.Click += AbilityButton_Click;
            MenuStackPanel.Children.Add(abilityButton);


            var abilityEffectButton = new Button
            {
                Name = "AbilityEffectButton",
                Content = "AbilityEffect",
                Width = 100,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10, 0, 0, 0)
            };

            abilityEffectButton.Click += AbilityEffectButton_Click;
            MenuStackPanel.Children.Add(abilityEffectButton);

            var conditionButton = new Button
            {
                Name = "ConditionButton",
                Content = "Condition",
                Width = 100,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10, 0, 0, 0)
            };

            conditionButton.Click += ConditionButton_Click;
            MenuStackPanel.Children.Add(conditionButton);
        }

        private void LoadInitMenu()
        {
            var editButton = new Button
            {
                Name = "EditButton",
                Content = "Edit",
                Width = 100,
                Height = 30,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(10, 0, 0, 0)
            };

            editButton.Click += EditButton_Click;
            MenuStackPanel.Children.Add(editButton);
        }

        private void ConditionButton_Click(object sender, EventArgs e)
        {
            FrameMain.Content = new ConditionCreation();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _gameState.Type = StateType.Edit;
            MenuStackPanel.Children.Clear();
            LoadEditMenu();
        }

        private void AbilityButton_Click(object sender, EventArgs e)
        {
            FrameMain.Content = new AbilityCreation();
        }

        private void AbilityEffectButton_Click(object sender, EventArgs e)
        {
            FrameMain.Content = new AbilityEffectsCreation();
        }
    }
}
