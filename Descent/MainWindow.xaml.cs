using System.Windows;
using DataLib.Characters.HeroData;
using DataLib.Contexts;
using Descent.Core;
using Descent.Core.GameEngine.Random;
using Descent.Gui.Editor;
using Descent.Gui.GameCreation;

namespace Descent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly RandomDice _diceRoller;

        private GameContext _gc;

        public MainWindow()
        {
            _diceRoller = new RandomDice();
            InitializeComponent();
            
            FrameMain.Content = new ConditionCreation();
        }
    }
}
