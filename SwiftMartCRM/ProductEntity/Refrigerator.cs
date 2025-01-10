using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMartCRM.ProductEntity
{
    /// <summary>
    /// Represents a refrigerator product, inheriting from the base Product class.
    /// </summary>
    /// <remarks>
    /// This class contains additional specific attributes for refrigerators, such as total volume, energy class, and physical dimensions.
    /// </remarks>
    public class Refrigerator : Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the refrigerator.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the total volume of the refrigerator.
        /// </summary>
        /// <remarks>
        /// The total volume represents the overall internal capacity of the refrigerator.
        /// </remarks>
        public string? TotalVolume { get; set; }

        /// <summary>
        /// Gets or sets the type of the refrigerator (e.g., top-freezer, bottom-freezer).
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the energy class of the refrigerator.
        /// </summary>
        /// <remarks>
        /// The energy class indicates the energy efficiency of the refrigerator (e.g., A+, B).
        /// </remarks>
        public string? EnergyClass { get; set; }

        /// <summary>
        /// Gets or sets the height of the refrigerator.
        /// </summary>
        public string? Height { get; set; }

        /// <summary>
        /// Gets or sets the width of the refrigerator.
        /// </summary>
        public string? Width { get; set; }

        /// <summary>
        /// Gets or sets the depth of the refrigerator.
        /// </summary>
        public string? Depth { get; set; }
    }
}
