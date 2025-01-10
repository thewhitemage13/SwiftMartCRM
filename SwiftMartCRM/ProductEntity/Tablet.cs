using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMartCRM.ProductEntity
{
    /// <summary>
    /// Represents a tablet product, inheriting from the base Product class.
    /// </summary>
    /// <remarks>
    /// This class contains specific attributes for tablets, such as screen size, CPU, camera, memory, and connectivity options like 3G, 4G, and 5G support.
    /// </remarks>
    public class Tablet : Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the tablet.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the tablet.
        /// </summary>
        public string? ScreenSize { get; set; }

        /// <summary>
        /// Gets or sets the screen resolution of the tablet.
        /// </summary>
        public string? ScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the CPU model of the tablet.
        /// </summary>
        public string? CPU { get; set; }

        /// <summary>
        /// Gets or sets the camera specifications of the tablet.
        /// </summary>
        public string? Camera { get; set; }

        /// <summary>
        /// Gets or sets the amount of RAM in the tablet.
        /// </summary>
        public string? RAM { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet supports a microSD card.
        /// </summary>
        public bool MicroSD { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet supports 3G connectivity.
        /// </summary>
        public bool Supports3G { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet supports LTE connectivity.
        /// </summary>
        public bool LTE { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet supports 5G connectivity.
        /// </summary>
        public bool Supports5G { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet has GPS support.
        /// </summary>
        public bool GPS { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet supports GLONASS (Russian satellite navigation system).
        /// </summary>
        public bool GLONASS { get; set; }

        /// <summary>
        /// Gets or sets whether the tablet supports BDS (Beidou Navigation Satellite System).
        /// </summary>
        public bool BDS { get; set; }
    }
}
