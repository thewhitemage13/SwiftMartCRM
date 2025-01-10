using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SwiftMart.UserEntities
{
    /// <summary>
    /// Represents a user of the system with basic details such as name, email, password, and role.
    /// </summary>
    /// <remarks>
    /// The <see cref="User"/> class is used to store the essential information for each user in the system.
    /// The class includes properties for user identification, authentication, and role management.
    /// </remarks>
    [Index(nameof(Email), IsUnique = true)]
    public partial class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        /// <remarks>
        /// The <see cref="Id"/> property is the primary key for the user in the database.
        /// </remarks>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        /// <remarks>
        /// The <see cref="Name"/> property stores the user's first name.
        /// </remarks>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        /// <remarks>
        /// The <see cref="Lastname"/> property stores the user's last name.
        /// </remarks>
        public string? Lastname { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        /// <remarks>
        /// The <see cref="Email"/> property stores the user's email, which must be unique.
        /// This field is indexed to enforce uniqueness.
        /// </remarks>
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the hashed password of the user.
        /// </summary>
        /// <remarks>
        /// The <see cref="Password"/> property stores the user's password in a hashed format for security purposes.
        /// </remarks>
        public string? Password { get; set; }

        /// <summary>
        /// Gets or sets the role of the user (e.g., Admin, Customer, Seller).
        /// </summary>
        /// <remarks>
        /// The <see cref="Role"/> property defines the user's role in the system, 
        /// which determines the level of access and permissions they have.
        /// </remarks>
        public string? Role { get; set; }
    }
}
