using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
using DataLib.Abilities;
using DataLib.Abilities.AbilityData;
using DataLib.Contexts;

namespace Descent.Gui.Editor
{
    /// <summary>
    /// Interaction logic for AbilityCreation.xaml
    /// </summary>
    public partial class AbilityCreation : Page
    {
        private ObservableCollection<AbilityEffect> _effectCollection;

        public AbilityCreation()
        {
            InitializeComponent();
            _effectCollection = GetAbilityEffects();

            EffectComboBox.ItemsSource = _effectCollection;
        }

        private ObservableCollection<AbilityEffect> GetAbilityEffects()
        {
            using (var context = new DescentContext())
            {
                return new ObservableCollection<AbilityEffect>(context.AbilityEffects.Select(a => a).ToList());
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            CreateAbility();
        }

        private void CreateAbility()
        {
            var ability = new Ability
            {
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text
            };

            ability.AbilityEffects = AbilityEffectsListBox.SelectedItems.OfType<AbilityEffect>().ToList();

            using (var context = new DescentContext())
            {
                context.Abilities.Attach(ability);
                context.Entry(ability).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        private void AddEffectButton_Click(object sender, RoutedEventArgs e)
        {
            AbilityEffectsListBox.Items.Add(EffectComboBox.SelectionBoxItem);
        }
    }
}
