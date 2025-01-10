using SwiftMart.Products;
using SwiftMart.WishlistEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using SwiftMart.OrderEntities;

namespace SwiftMart.UserEntities
{
    /// <summary>
    /// Represents a customer in the system who can manage their cart, orders, and wishlist.
    /// </summary>
    /// <remarks>
    /// The <see cref="Customer"/> class provides functionality for a user to perform actions such as 
    /// purchasing products, managing their shopping cart, canceling orders, and managing a wishlist.
    /// </remarks>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer's shopping cart containing products they intend to purchase.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Gets or sets the list of orders made by the customer.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the customer's wishlist containing products they are interested in purchasing later.
        /// </summary>
        public Wishlist Wishlist { get; set; }

        /// <summary>
        /// Adds a product to the customer's cart, initiating the purchase process.
        /// </summary>
        /// <param name="product">The product to add to the cart.</param>
        /// <remarks>
        /// The method allows a customer to add a product to their shopping cart for later checkout. 
        /// Additional logic to handle product addition to the cart can be implemented in this method.
        /// </remarks>
        public void BuyProduct(Product product)
        {
            // Logic to add the product to the cart for purchase will be added here.
        }

        /// <summary>
        /// Cancels an existing order placed by the customer.
        /// </summary>
        /// <param name="order">The order to cancel.</param>
        /// <remarks>
        /// This method provides functionality for canceling an order. It may involve updating the order 
        /// status and processing any necessary refunds or notifications to the customer.
        /// </remarks>
        public void CancelOrder(Order order)
        {
            // Logic to cancel the order will be added here.
        }
    }
}
