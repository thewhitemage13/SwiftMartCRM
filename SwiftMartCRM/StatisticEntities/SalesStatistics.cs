using SwiftMart.Products;

namespace SwiftMart.StatisticEntities
{
    /// <summary>
    /// Represents statistics related to sales, including popular products and total sales.
    /// </summary>
    /// <remarks>
    /// This class is designed to hold and manage sales statistics, such as tracking popular products 
    /// and calculating the total number of sales.
    /// </remarks>
    public class SalesStatistics
    {
        /// <summary>
        /// Gets or sets the list of popular products based on sales data.
        /// </summary>
        /// <remarks>
        /// The list contains instances of <see cref="Product"/> that are identified as most popular 
        /// based on the sales data.
        /// </remarks>
        public List<Product> PopularProducts { get; set; }

        /// <summary>
        /// Gets or sets the total number of sales recorded.
        /// </summary>
        /// <remarks>
        /// This property represents the sum of all sales made, providing a total count for sales reporting.
        /// </remarks>
        public int TotalSales { get; set; }

        /// <summary>
        /// Generates a sales report based on the current statistics.
        /// </summary>
        /// <remarks>
        /// The <see cref="GenerateReport"/> method can be expanded to provide detailed analytics and reporting 
        /// on the sales, including popular products and total sales count.
        /// </remarks>
        public void GenerateReport()
        {
            // Method logic for generating the report will be added here.
        }
    }
}
