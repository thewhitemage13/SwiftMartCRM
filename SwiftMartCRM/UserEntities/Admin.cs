using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.UserEntities
{

    /// <summary>
    /// Represents an administrator user who has elevated permissions to moderate products and manage users.
    /// </summary>
    /// <remarks>
    /// The <see cref="Admin"/> class extends the <see cref="User"/> class and provides additional capabilities 
    /// for managing products and users within the system.
    /// </remarks>
    public class Admin : User
    {

        /// <summary>
        /// Moderates a product, allowing administrators to manage product visibility, status, or other settings.
        /// </summary>
        /// <param name="productId">The unique identifier of the product to moderate.</param>
        /// <remarks>
        /// The method is intended to be extended with logic to modify the product's properties or status, 
        /// such as approving, rejecting, or flagging the product.
        /// </remarks>
        public void ModerateProduct(int productId)
        {

        }

        /// <summary>
        /// Manages users, allowing administrators to perform actions such as adding, removing, or updating user accounts.
        /// </summary>
        /// <remarks>
        /// The method is intended to be extended with logic to manage user data, such as approving new registrations 
        /// or handling account suspensions.
        /// </remarks>
        public void ManageUsers()
        {

        }
    }
}
