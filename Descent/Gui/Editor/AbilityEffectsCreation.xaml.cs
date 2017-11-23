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
using DataLib.Abilities.AbilityData;
using DataLib.Contexts;

namespace Descent.Gui.Editor
{
    /// <summary>
    /// Interaction logic for AbilityEffectsCreation.xaml
    /// </summary>
    public partial class AbilityEffectsCreation : Page
    {
        public AbilityEffectsCreation()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (EffectTypeComboBox.SelectionBoxItem.ToString() == "MovementEffect")
            {
                CreateMovementAbilityEffect();
            }
        }

        private void CreateMovementAbilityEffect()
        {
            var effect = new MovementAbilityEffect
            {
                Name = NameTextBox.Text,
                MovementEffectRestriction = Convert.ToInt32(SetMovesTextBox.Text)
            };

            using (var context = new DescentContext())
            {
                context.AbilityEffects.Add(effect);
                context.SaveChanges();
            }
        }
    }
}
