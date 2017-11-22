using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DataLib.Contexts;
using Condition = DataLib.Conditions.Condition;

namespace Descent.Gui.Editor
{
    /// <summary>
    /// Interaction logic for ConditionCreation.xaml
    /// </summary>
    public partial class ConditionCreation : Page
    {
        private ObservableCollection<DataLib.Conditions.Condition> _conditions;
        public ConditionCreation()
        {
            InitializeComponent();
            _conditions = GetConditions();
            ConditionListBox.ItemsSource = _conditions;
        }

        private ObservableCollection<Condition> GetConditions()
        {
            using (var conditionContext = new ConditionContext())
            {
                return new ObservableCollection<Condition>(conditionContext.Conditions.Select(c => c).ToList());
            }
        }

        private void CreateCondition()
        {
            using (var conditionContext = new ConditionContext())
            {
                var condition = new Condition
                {
                    Name = NameTextBox.Text,
                    Description = DescriptionTextBox.Text
                };

                conditionContext.Conditions.Add(condition);
                conditionContext.SaveChanges();

                _conditions = GetConditions();
                ConditionListBox.ItemsSource = _conditions;
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            CreateCondition();
        }
    }
}
