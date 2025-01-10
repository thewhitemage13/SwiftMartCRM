using SwiftMart.DataBase;
using SwiftMart.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Validations
{
    public class UserValidator
    {
        private readonly Context context;

        public UserValidator(Context context)
        {
            this.context = context;
        }

        public bool ValidateRegistration(string name, string lastName, string email, string password, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please fill in all the fields.";
                return false;
            }

            if (!IsValidEmail(email))
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            if (context.Admins.Any(u => u.Email == email))
            {
                errorMessage = "Email is already registered.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public bool ValidateLogin(string email, string password, out string errorMessage)
        {
            var user = context.Admins.SingleOrDefault(u => u.Email == email);
            if (user == null)
            {
                errorMessage = "User with the provided email not found.";
                return false;
            }

            if (!PasswordHasher.VerifyPassword(password, user.Password))
            {
                errorMessage = "Incorrect password.";
                return false;
            }

            if (user.Role != "Admin")
            {
                errorMessage = "You do not have permission to use this application.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
