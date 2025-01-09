using System.Windows;
using System.Windows.Controls;

namespace SwiftMartCRM
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {


        public AdminWindow()
        {
            InitializeComponent();
        }

        private void SubcategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SubcategoryComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedSubcategory = selectedItem.Content.ToString();

                DynamicFields.Content = null;

                switch (selectedSubcategory)
                {
                    case "Phones":
                        
                        DynamicFields.Content = new PhoneControl();
                        break;

                    case "Wachine machines":
                        DynamicFields.Content = new WachineMachineControl();
                        break;

                    case "Refrigerators":
                        DynamicFields.Content = new RefrigeratorsControl();
                        break;

                    case "Tablets":
                        DynamicFields.Content = new TabletsControl();
                        break;

                    case "TVs":
                        DynamicFields.Content = new TVsControl();
                        break;

                    case "Laptops":
                        DynamicFields.Content = new LaptopsControl();
                        break;

                    default:
                        DynamicFields.Content = new TextBlock
                        {
                            Text = "No specific fields for this subcategory",
                            Margin = new Thickness(10)
                        };
                        break;
                }
            }
        }
    }
}
