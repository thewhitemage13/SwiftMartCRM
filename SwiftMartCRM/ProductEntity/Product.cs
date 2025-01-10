using SwiftMart.CategoryEntity;
using SwiftMart.ReviewEntity;
using SwiftMartCRM.CategoryEntity;

namespace SwiftMart.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; } 
        public int SubcategoryId { get; set; }
        public Subcategory? Subcategory { get; set; }
        public Review? Review { get; set; }
        public List<string>? photos { get; set; } = new List<string>();
    }
}
