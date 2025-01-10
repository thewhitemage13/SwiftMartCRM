using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.ProductEntity
{
    /// <summary>
    /// Represents a store that sells products.
    /// </summary>
    /// <remarks>
    /// This class contains the name of the store and a list of products available in that store.
    /// </remarks>
    public class Store
    {
        /// <summary>
        /// Gets or sets the name of the store.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of products available in the store.
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class with a specified store name.
        /// </summary>
        /// <param name="name">The name of the store.</param>
        public Store(string name)
        {
            Name = name;
            Products = new List<Product>();
        }
    }
}
