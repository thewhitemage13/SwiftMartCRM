using SwiftMart.ProductEntity;
using SwiftMart.Products;
using SwiftMart.StatisticEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.UserEntities
{
    /// <summary>
    /// Represents a seller who manages a store and has a list of products and sales statistics.
    /// </summary>
    /// <remarks>
    /// The <see cref="Seller"/> class provides functionality for a seller to manage their store, 
    /// including adding products, viewing sales statistics, and performing store management tasks.
    /// </remarks>
    public class Seller
    {
        /// <summary>
        /// Gets or sets the store owned by the seller.
        /// </summary>
        /// <remarks>
        /// The <see cref="Store"/> property represents the seller's store, where products are listed 
        /// and managed.
        /// </remarks>
        public Store Store { get; set; }

        /// <summary>
        /// Gets or sets the list of products owned by the seller.
        /// </summary>
        /// <remarks>
        /// The <see cref="Products"/> property holds the list of products that the seller is offering 
        /// for sale.
        /// </remarks>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the sales statistics for the seller's store.
        /// </summary>
        /// <remarks>
        /// The <see cref="Statistics"/> property provides sales data and insights for the seller's 
        /// products and store performance.
        /// </remarks>
        public SalesStatistics Statistics { get; set; }

        /// <summary>
        /// Manages the seller's store, including tasks such as updating store details and adding/removing products.
        /// </summary>
        /// <remarks>
        /// This method provides functionality for managing the store, including modifying store 
        /// settings, viewing reports, and managing the products available in the store.
        /// </remarks>
        public void ManageStore()
        {
            // Logic to manage the store will be added here.
        }
    }
}
