using SwiftMart.Commands;
using SwiftMart.DataBase;
using SwiftMart.EmailTools;
using SwiftMart.Hash;
using SwiftMart.Sessions;
using SwiftMart.UserEntities;
using SwiftMart.Validations;
using SwiftMartCRM;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SwiftMart.ViewModel
{
    /// <summary>
    /// ViewModel for user registration and login operations.
    /// </summary>
    /// <remarks>
    /// The <see cref="UserViewModel"/> class handles user registration, login, and session management.
    /// It validates user input, hashes passwords, and interacts with the database and email service.
    /// </remarks>
    public class UserViewModel : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string lastName;
        private string email;
        private string password;
        private string role;
        private readonly Context context;
        private readonly UserValidator userValidator;

        /// <summary>
        /// Command for user registration.
        /// </summary>
        public ICommand RegisterCommand { get; }

        /// <summary>
        /// Command for user login.
        /// </summary>
        public ICommand LoginCommand { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel"/> class.
        /// </summary>
        public UserViewModel()
        {
            context = new Context();
            userValidator = new UserValidator(context);

            RegisterCommand = new AsyncRelayCommand(Register);
            LoginCommand = new RelayCommand(Login);
        }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        /// <summary>
        /// Gets or sets the user's last name.
        /// </summary>
        public string Lastname
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        /// <summary>
        /// Gets or sets the user's email.
        /// </summary>
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        /// <summary>
        /// Gets or sets the user's password.
        /// </summary>
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        /// <summary>
        /// Gets or sets the user's role.
        /// </summary>
        public string Role
        {
            get => role;
            set => SetProperty(ref role, value);
        }

        /// <summary>
        /// Event raised when a property changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Called when a property has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property that changed.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets a property value and raises the <see cref="PropertyChanged"/> event if the value has changed.
        /// </summary>
        /// <typeparam name="T">The type of the property.</typeparam>
        /// <param name="field">The backing field for the property.</param>
        /// <param name="value">The new value of the property.</param>
        /// <param name="propertyName">The name of the property being set.</param>
        /// <returns>Returns true if the property value was changed, otherwise false.</returns>
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Handles the login operation.
        /// </summary>
        /// <param name="parameter">The parameter passed to the command.</param>
        private void Login(object parameter)
        {
            if (userValidator.ValidateLogin(email, password, out string errorMessage))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                OpenHomeShop();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Handles the registration operation asynchronously.
        /// </summary>
        private async Task Register()
        {
            if (userValidator.ValidateRegistration(Name, Lastname, Email, Password, out string errorMessage))
            {
                string hashedPassword = PasswordHasher.HashPassword(Password);

                var newAdmin = new Admin
                {
                    Name = Name,
                    Lastname = Lastname,
                    Email = Email,
                    Password = hashedPassword,
                    Role = "Admin"
                };

                context.Admins.Add(newAdmin);
                context.SaveChanges();

                try
                {
                    var emailService = new EmailService();
                    await emailService.Sender(Email, Name);
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    AdminSession.Instance.Id = newAdmin.Id;
                    AdminSession.Instance.Name = newAdmin.Name;

                    OpenHomeShop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Opens the Home Shop window after successful login or registration.
        /// </summary>
        private void OpenHomeShop()
        {
            var currentWindow = Application.Current.Windows.OfType<Window>().First(w => w.IsActive);
            currentWindow.Visibility = Visibility.Hidden;

            try
            {
                var adminWindow = new AdminWindow();
                adminWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening HomeShop: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
