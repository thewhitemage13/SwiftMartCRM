using SwiftMart.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMartCRM.ProductEntity
{
    /// <summary>
    /// Represents a television product, inheriting from the base Product class.
    /// </summary>
    /// <remarks>
    /// This class contains specific attributes for televisions, such as screen size, resolution, frequency, operating system, and support for different DVB standards.
    /// </remarks>
    public class TV : Product
    {
        /// <summary>
        /// Gets or sets the diagonal screen size of the TV.
        /// </summary>
        public string? ScreenDiagonal { get; set; }

        /// <summary>
        /// Gets or sets the screen resolution of the TV (e.g., 1080p, 4K).
        /// </summary>
        public string? ScreenResolution { get; set; }

        /// <summary>
        /// Gets or sets the screen refresh rate (frequency) of the TV (e.g., 60Hz, 120Hz).
        /// </summary>
        public string? ScreenFrequency { get; set; }

        /// <summary>
        /// Gets or sets the operating system of the TV (e.g., Android TV, WebOS, Tizen).
        /// </summary>
        public string? OS { get; set; }

        /// <summary>
        /// Gets or sets whether the TV supports DVB-C (Cable Television) broadcasting.
        /// </summary>
        public bool DVB_C { get; set; }

        /// <summary>
        /// Gets or sets whether the TV supports DVB-S2 (Satellite Television) broadcasting.
        /// </summary>
        public bool DVB_S2 { get; set; }

        /// <summary>
        /// Gets or sets whether the TV supports DVB-T2 (Terrestrial Television) broadcasting.
        /// </summary>
        public bool DVB_T2 { get; set; }
    }
}
