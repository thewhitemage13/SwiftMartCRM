using SwiftMart.CategoryEntity;
using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMartCRM.CategoryEntity
{

    /// <summary>
    /// Represents a subcategory of products within a specific category in the SwiftMart system.
    /// </summary>
    /// <remarks>
    /// A subcategory further refines the classification of products under a main category.
    /// For example, the "Mobile Phones" subcategory might be part of the "Electronics" category.
    /// </remarks>
    public class Subcategory
    {

        /// <summary>
        /// Gets or sets the unique identifier for the subcategory.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the subcategory.
        /// </summary>
        /// <remarks>
        /// The subcategory name is a descriptive label used to identify the subcategory, such as "Smartphones" or "Laptops."
        /// </remarks>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the foreign key reference to the parent category.
        /// </summary>
        /// <remarks>
        /// This property links the subcategory to its parent category, establishing the relationship.
        /// </remarks>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the reference to the parent category of the subcategory.
        /// </summary>
        /// <remarks>
        /// The <see cref="Category"/> property represents the main category under which the subcategory is classified.
        /// </remarks>
        public Category? Category { get; set; }

        /// <summary>
        /// Gets or sets the collection of products associated with this subcategory.
        /// </summary>
        /// <remarks>
        /// This collection contains the products that belong to this particular subcategory.
        /// </remarks>
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
