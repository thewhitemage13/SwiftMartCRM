using SwiftMart.WishlistEntity;

namespace SwiftMart.Accounts
{

    /// <summary>
    /// Represents a customer account in the SwiftMart system.
    /// </summary>
    /// <remarks>
    /// This class inherits from the <see cref="Account"/> base class and adds properties
    /// and methods specific to customers, such as managing order history and interacting
    /// with a wishlist.
    /// </remarks>
    public class CustomerAccount : Account
    {

        /// <summary>
        /// Gets or sets the order history for the customer account.
        /// </summary>
        /// <remarks>
        /// Each entry in the list represents an order ID associated with the customer.
        /// </remarks>
        public List<int> OrderHistory { get; set; }

        // TODO: Uncomment and implement when the Wishlist class is available.
        // /// <summary>
        // /// Gets or sets the wishlist associated with the customer account.
        // /// </summary>
        //public Wishlist wishlist { get; set; } -- TO DO

        /// <summary>
        /// Displays the personal information of the customer.
        /// </summary>
        /// <remarks>
        /// This method provides functionality to view details such as the customer's
        /// username, email, and profile photo.
        /// </remarks>
        public void ViewPersonalInfo()
        {

        }

        /// <summary>
        /// Displays the customer-specific dashboard.
        /// </summary>
        /// <remarks>
        /// This method provides an overview tailored to the customer, such as recent
        /// orders, recommended products, and account status.
        /// </remarks>
        public void DisplayDashboard()
        {

        }
    }
}
