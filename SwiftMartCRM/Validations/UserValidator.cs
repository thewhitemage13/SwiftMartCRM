using SwiftMart.DataBase;
using SwiftMart.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Validations
{
    /// <summary>
    /// Class for validating user registration and login information.
    /// </summary>
    /// <remarks>
    /// The <see cref="UserValidator"/> class provides methods to validate user registration and login details.
    /// It checks if all required fields are filled, if the email is valid, and if the password matches the stored hash.
    /// </remarks>
    public class UserValidator
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserValidator"/> class.
        /// </summary>
        /// <param name="context">The database context used to query the user data.</param>
        public UserValidator(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Validates the registration input for a new user.
        /// </summary>
        /// <param name="name">The first name of the user.</param>
        /// <param name="lastName">The last name of the user.</param>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password for the user account.</param>
        /// <param name="errorMessage">An output parameter that will contain the error message if validation fails.</param>
        /// <returns>Returns true if the registration is valid, otherwise false.</returns>
        public bool ValidateRegistration(string name, string lastName, string email, string password, out string errorMessage)
        {
            // Check if any of the fields are empty or contain only whitespace
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please fill in all the fields.";
                return false;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                errorMessage = "Invalid email format.";
                return false;
            }

            // Check if the email is already registered in the database
            if (context.Admins.Any(u => u.Email == email))
            {
                errorMessage = "Email is already registered.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Validates the login input for a user.
        /// </summary>
        /// <param name="email">The email address of the user.</param>
        /// <param name="password">The password for the user account.</param>
        /// <param name="errorMessage">An output parameter that will contain the error message if validation fails.</param>
        /// <returns>Returns true if the login is valid, otherwise false.</returns>
        public bool ValidateLogin(string email, string password, out string errorMessage)
        {
            // Find the user with the provided email
            var user = context.Admins.SingleOrDefault(u => u.Email == email);
            if (user == null)
            {
                errorMessage = "User with the provided email not found.";
                return false;
            }

            // Verify if the entered password matches the stored password hash
            if (!PasswordHasher.VerifyPassword(password, user.Password))
            {
                errorMessage = "Incorrect password.";
                return false;
            }

            // Ensure the user has the correct role to access the application
            if (user.Role != "Admin")
            {
                errorMessage = "You do not have permission to use this application.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Checks if the given email is in a valid format.
        /// </summary>
        /// <param name="email">The email address to check.</param>
        /// <returns>Returns true if the email is in a valid format, otherwise false.</returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                // Attempt to create a new MailAddress object to validate the email format
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
