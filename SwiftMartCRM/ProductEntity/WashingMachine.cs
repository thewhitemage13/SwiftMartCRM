using SwiftMart.Products;

namespace SwiftMartCRM.ProductEntity
{
    /// <summary>
    /// Represents a washing machine product, inheriting from the base Product class.
    /// </summary>
    /// <remarks>
    /// This class contains specific attributes for washing machines, such as maximum load, spin class, washing class, water consumption, and energy class.
    /// </remarks>
    public class WashingMachine : Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the washing machine.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the maximum load capacity of the washing machine (e.g., in kilograms).
        /// </summary>
        public string? MaxLoad { get; set; }

        /// <summary>
        /// Gets or sets the spin class of the washing machine (e.g., A, B, C, etc.), which indicates its spin efficiency.
        /// </summary>
        public string? SpinClass { get; set; }

        /// <summary>
        /// Gets or sets the washing class of the washing machine (e.g., A, B, C, etc.), which indicates its washing efficiency.
        /// </summary>
        public string? WashingClass { get; set; }

        /// <summary>
        /// Gets or sets the water consumption of the washing machine (e.g., in liters per cycle).
        /// </summary>
        public string? WaterConsumption { get; set; }

        /// <summary>
        /// Gets or sets the energy class of the washing machine (e.g., A++, A+, etc.), which indicates its energy efficiency.
        /// </summary>
        public string? EnergyClass { get; set; }
    }
}
