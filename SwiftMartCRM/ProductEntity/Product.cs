using SwiftMart.CategoryEntity;
using SwiftMart.ReviewEntity;
using SwiftMartCRM.CategoryEntity;

namespace SwiftMart.Products
{
    /// <summary>
    /// Represents a product in the system.
    /// </summary>
    /// <remarks>
    /// This class contains details about a product, including its name, description, price, category, subcategory,
    /// review, and photos.
    /// </remarks>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product as a string.
        /// </summary>
        /// <remarks>
        /// The price is stored as a string, but it can be converted into a decimal or other numeric type if necessary.
        /// </remarks>
        public string? Price { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the category to which the product belongs.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category that the product belongs to.
        /// </summary>
        public Category? Category { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the subcategory to which the product belongs.
        /// </summary>
        public int SubcategoryId { get; set; }

        /// <summary>
        /// Gets or sets the subcategory that the product belongs to.
        /// </summary>
        public Subcategory? Subcategory { get; set; }

        /// <summary>
        /// Gets or sets the review associated with the product.
        /// </summary>
        public Review? Review { get; set; }

        /// <summary>
        /// Gets or sets the list of URLs of photos associated with the product.
        /// </summary>
        public List<string>? photos { get; set; } = new List<string>();
    }
}
