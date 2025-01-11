using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SwiftMart
{
    /// <summary>
    /// Interaction logic for RegistrationAuthorization.xaml
    /// </summary>
    public partial class RegistrationAuthorization : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationAuthorization"/> class.
        /// </summary>
        public RegistrationAuthorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the register button. 
        /// Switches the view from the login form to the registration form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void Register_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LoginForm.Visibility = Visibility.Collapsed;
            RegisterForm.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the click event for the back-to-login button. 
        /// Switches the view from the registration form to the login form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseButtonEventArgs"/> instance containing the event data.</param>
        private void BackToLogin_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            RegisterForm.Visibility = Visibility.Collapsed;
            LoginForm.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the GotFocus event for the email text box in the login form.
        /// Clears the placeholder text and changes the text color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (AuthorizationEmailTextBox.Text == "Email")
            {
                AuthorizationEmailTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        /// <summary>
        /// Handles the LostFocus event for the email text box in the login form.
        /// Restores the placeholder text if the text box is empty.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AuthorizationEmailTextBox.Text))
            {
                AuthorizationEmailTextBox.Text = "Email";
            }
        }

        /// <summary>
        /// Handles the GotFocus event for the name text box in the registration form.
        /// Clears the placeholder text and changes the text color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void RegistrationNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RegistrationNameTextBox.Text == "Name *")
            {
                RegistrationNameTextBox.Text = string.Empty;
                AuthorizationEmailTextBox.Foreground = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
            }
        }

        /// <summary>
        /// Handles the LostFocus event for the name text box in the registration form.
        /// Restores the placeholder text if the text box is empty.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void RegistrationNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegistrationNameTextBox.Text))
            {
                RegistrationNameTextBox.Text = "Name *";
            }
        }

        // Similar XML comments can be added for the remaining methods:
        // RegistrationLastNameTextBox_GotFocus
        // RegistrationLastNameTextBox_LostFocus
        // RegistrationEmailTextBox_GotFocus
        // RegistrationEmailTextBox_LostFocus

        /// <summary>
        /// Handles the click event for a button to retrieve the password from the password box.
        /// Displays the password in a message box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.Password = MyPasswordBox.Password;
            MessageBox.Show(VM.Password);
        }

        /// <summary>
        /// Handles the click event for a button to retrieve the password from another password box.
        /// Displays the password in a message box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VM.Password = Autorization.Password;
            MessageBox.Show(VM.Password);
        }
    }
}
