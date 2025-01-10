using System.Windows;
using System.Windows.Controls;

namespace SwiftMartCRM
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// This window allows an administrator to manage different product categories dynamically.
    /// Based on the selected product subcategory, the relevant control will be displayed.
    /// </summary>
    public partial class AdminWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminWindow"/> class.
        /// This constructor sets up the window and its components.
        /// </summary>
        public AdminWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the selection change in the <see cref="SubcategoryComboBox"/>.
        /// Based on the selected subcategory, it dynamically loads the appropriate control to manage that category.
        /// </summary>
        /// <param name="sender">The source of the event, typically the ComboBox.</param>
        /// <param name="e">The event data containing the selection information.</param>
        private void SubcategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SubcategoryComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string? selectedSubcategory = selectedItem.Content.ToString();

                // Clears previous dynamic content
                DynamicFields.Content = null;

                // Loads the appropriate control based on the selected subcategory
                switch (selectedSubcategory)
                {
                    case "Phones":
                        DynamicFields.Content = new PhoneControl();
                        break;

                    case "Washing machines":
                        DynamicFields.Content = new WashingMachineControl();
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
                        // Shows a fallback message when the subcategory does not match
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
