using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Sessions
{

    /// <summary>
    /// Represents a session for the currently logged-in administrator.
    /// </summary>
    /// <remarks>
    /// This class implements the Singleton pattern to ensure that only one instance of the session exists throughout the application's lifecycle.
    /// It stores information about the currently authenticated administrator, such as their ID, name, and address.
    /// </remarks>
    public class AdminSession
    {
        private static AdminSession instance;

        /// <summary>
        /// Gets the singleton instance of the <see cref="AdminSession"/>.
        /// </summary>
        public static AdminSession Instance => instance ??= new AdminSession();

        /// <summary>
        /// Gets or sets the unique identifier of the currently logged-in administrator.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the currently logged-in administrator.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address of the currently logged-in administrator.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSession"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor is private to enforce the Singleton pattern, meaning the session can only be created through the <see cref="Instance"/> property.
        /// </remarks>
        private AdminSession() { }
    }
}
