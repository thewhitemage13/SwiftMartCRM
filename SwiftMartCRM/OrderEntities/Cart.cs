using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.OrderEntities
{

    /// <summary>
    /// Represents a shopping cart that holds products selected by the customer.
    /// </summary>
    /// <remarks>
    /// This class allows the user to add, remove, and clear products from the cart.
    /// It maintains a list of product IDs as a representation of the products in the cart.
    /// </remarks>
    public class Cart
    {

        /// <summary>
        /// Gets or sets the list of product IDs in the cart.
        /// </summary>
        /// <remarks>
        /// This list holds the IDs of the products that have been added to the cart.
        /// </remarks>
        public List<int> ProductID { get; set; }

        /// <summary>
        /// Adds a product to the cart.
        /// </summary>
        /// <param name="product">The product to be added to the cart.</param>
        /// <remarks>
        /// This method is used to add a product to the cart. The product is represented by its ID.
        /// </remarks>
        public void AddToCart(Product product)
        {

        }

        /// <summary>
        /// Removes a product from the cart.
        /// </summary>
        /// <param name="product">The product to be removed from the cart.</param>
        /// <remarks>
        /// This method is used to remove a product from the cart based on its ID.
        /// </remarks>
        public void RemoveFromCart(Product product)
        {

        }

        /// <summary>
        /// Clears all products from the cart.
        /// </summary>
        /// <remarks>
        /// This method removes all products from the cart.
        /// </remarks>
        public void ClearCart(Product product)
        {

        }
    }
}
