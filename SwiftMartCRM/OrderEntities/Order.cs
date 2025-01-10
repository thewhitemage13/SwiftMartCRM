using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.OrderEntities
{

    /// <summary>
    /// Represents an order placed by a customer in the system.
    /// </summary>
    /// <remarks>
    /// This class contains details of an order, including the customer, products, order status, delivery address,
    /// creation date, and total price.
    /// </remarks>
    public class Order
    {

        /// <summary>
        /// Gets or sets the unique identifier for the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the customer who placed the order.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the list of product IDs included in the order.
        /// </summary>
        /// <remarks>
        /// This list contains the IDs of the products that are part of the order.
        /// </remarks>
        public List<int> ProductID { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        /// <remarks>
        /// The status can indicate whether the order is pending, completed, shipped, etc.
        /// </remarks>
        public enum Status;

        /// <summary>
        /// Gets or sets the delivery address for the order.
        /// </summary>
        public string DelaveryAddress { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the order was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the total price of the order.
        /// </summary>
        public float TotalPrice { get; set; }


    }
}
