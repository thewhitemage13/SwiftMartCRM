using SwiftMart.Products;
using System.Security.Cryptography.X509Certificates;

namespace SwiftMart.Accounts
{

    /// <summary>
    /// Represents a seller account in the SwiftMart system.
    /// </summary>
    /// <remarks>
    /// This class inherits from the <see cref="Account"/> base class and is designed for users
    /// who operate as sellers. It includes properties and methods specific to managing a store
    /// and products.
    /// </remarks>
    public class SellerAccount : Account
    {

        /// <summary>
        /// Gets or sets the name of the store associated with the seller account.
        /// </summary>
        public string StoreName { get; set; }

        // TODO: Uncomment and implement when the Product class is available.
        // /// <summary>
        // /// Gets or sets the list of products sold by the seller.
        // /// </summary>
        //public List<Product> Products { get; set; } -- TO DO

        /// <summary>
        /// Displays the personal information of the seller.
        /// </summary>
        /// <remarks>
        /// This method provides functionality to view details such as the seller's username,
        /// email, and profile photo.
        /// </remarks>
        public void ViewPersonalInfo()
        {

        }

        /// <summary>
        /// Displays the seller-specific dashboard.
        /// </summary>
        /// <remarks>
        /// This method provides an overview tailored to the seller, such as sales performance,
        /// inventory status, and account information.
        /// </remarks>
        public void DisplayDashboard()
        {

        }
    }
}
