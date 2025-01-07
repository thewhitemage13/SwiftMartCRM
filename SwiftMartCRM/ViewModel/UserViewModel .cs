﻿using SwiftMart.Commands;
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
    public class UserViewModel : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string lastName;
        private string email;
        private string password;
        private string address;
        private string role;
        private readonly Context context;
        private readonly UserValidator userValidator;
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }
        public UserViewModel()
        {
            context = new Context();
            userValidator = new UserValidator(context);

            RegisterCommand = new AsyncRelayCommand(Register);
            LoginCommand = new RelayCommand(Login);
        }

        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string Lastname
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string Role
        {
            get => role;
            set => SetProperty(ref role, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

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

        private async Task Register()
        {
            if (userValidator.ValidateRegistration(Name, Lastname, Email, Password, Address, out string errorMessage))
            {
                string hashedPassword = PasswordHasher.HashPassword(Password);

                var newAdmin = new Admin
                {
                    Name = Name,
                    Lastname = Lastname,
                    Email = Email,
                    Password = hashedPassword,
                    Address = Address,
                    Role = "Admin"
                };

                context.Admin.Add(newAdmin);
                context.SaveChanges();

                try
                {
                    var emailService = new EmailService();
                    await emailService.Sender(Email, Name);
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    AdminSession.Instance.Id = newAdmin.Id;
                    AdminSession.Instance.Address = newAdmin.Address;
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
