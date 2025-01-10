using SwiftMartCRM.CategoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.CategoryEntity
{

    /// <summary>
    /// Represents a product category in the SwiftMart system.
    /// </summary>
    /// <remarks>
    /// A category groups related products together and can contain multiple subcategories.
    /// </remarks>
    public class Category
    {

        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <remarks>
        /// The category name is a descriptive label used to identify the category, such as "Electronics" or "Clothing."
        /// </remarks>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of subcategories associated with this category.
        /// </summary>
        /// <remarks>
        /// Each subcategory further classifies products within the category. 
        /// For example, the "Electronics" category may include subcategories like "Mobile Phones" and "Laptops."
        /// </remarks>
        public ICollection<Subcategory> Subcategories { get; set; } = new List<Subcategory>();
    }
}
