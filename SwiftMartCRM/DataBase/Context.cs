using FluentEmail.Core.Models;
using Microsoft.EntityFrameworkCore;
using SwiftMart.Accounts;
using SwiftMart.CategoryEntity;
using SwiftMart.OrderEntities;
using SwiftMart.ReviewEntity;
using SwiftMart.UserEntities;
using SwiftMart.WishlistEntity;
using SwiftMartCRM.CategoryEntity;
using SwiftMartCRM.ProductEntity;

namespace SwiftMart.DataBase
{

    /// <summary>
    /// Represents the database context for the SwiftMart application.
    /// </summary>
    /// <remarks>
    /// This class inherits from <see cref="DbContext"/> and is responsible for interacting with the 
    /// underlying database, defining DbSets for entities, and configuring database connections.
    /// </remarks>
    public class Context : DbContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Context"/> class.
        /// </summary>
        /// <remarks>
        /// The constructor currently does not perform any actions related to database creation or deletion.
        /// The database creation is handled through configuration options, such as using migrations or manual initialization.
        /// </remarks>
        public Context()
        {
            //Database.EnsureDeleted();
           // Database.EnsureCreated();
        }

        /// <summary>
        /// Configures the database connection and provider.
        /// </summary>
        /// <param name="optionsBuilder">The options builder used to configure the database context.</param>
        /// <remarks>
        /// The current implementation uses PostgreSQL with connection details defined via the connection string.
        /// </remarks>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=swiftmart;username=postgres;password=root");
        }

        /// <summary>
        /// Gets or sets the DbSet of categories in the database.
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of subcategories in the database.
        /// </summary>
        public DbSet<Subcategory> Subcategories { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of TVs in the database.
        /// </summary>
        public DbSet<TV> TVs { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of admin accounts in the database.
        /// </summary>
        public DbSet<Admin> Admins { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of customer accounts in the database.
        /// </summary>
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of reviews in the database.
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of carts in the database.
        /// </summary>
        public DbSet<Cart> Carts { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of orders in the database.
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of wishlists in the database.
        /// </summary>
        public DbSet<Wishlist> Wishlists { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of addresses in the database.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the DbSet of customers in the database.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
    }
}
