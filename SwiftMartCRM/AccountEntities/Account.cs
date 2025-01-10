using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Accounts
{

    /// <summary>
    /// Represents the base class for all account types in the SwiftMart system.
    /// </summary>
    public abstract class Account
    {

        /// <summary>
        /// Gets or sets the unique identifier for the account.
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the username associated with the account.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email address associated with the account.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the URL of the account holder's profile photo.
        /// </summary>
        public string AccountPhotoUrl { get; set; }

        /// <summary>
        /// Displays the personal information of the account holder.
        /// </summary>
        public void ViewPersonalInfo()
        {

        }

        /// <summary>
        /// Allows the account holder to update their personal information.
        /// </summary>
        public void UpdatePersonalInfo()
        {

        }

        /// <summary>
        /// Displays the account-specific dashboard.
        /// </summary>
        public void DisplayDashboard()
        {

        }
     }
}
