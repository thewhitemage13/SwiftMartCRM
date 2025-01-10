using SwiftMart.DataBase;
using SwiftMartCRM.ProductEntity;

namespace SwiftMartCRM.Services
{
    /// <summary>
    /// Provides services for handling operations related to TV products.
    /// </summary>
    /// <remarks>
    /// This service class is responsible for managing the persistence of TV entities in the database, such as saving a TV product.
    /// </remarks>
    public class TVService
    {
        private readonly Context context;

        /// <summary>
        /// Initializes a new instance of the <see cref="TVService"/> class.
        /// </summary>
        /// <remarks>
        /// The constructor initializes the database context which is used to interact with the database.
        /// </remarks>
        public TVService()
        {
            context = new Context();
        }

        /// <summary>
        /// Saves the provided TV entity to the database.
        /// </summary>
        /// <param name="tV">The TV product to be saved.</param>
        /// <remarks>
        /// The method adds the TV entity to the database context and commits the changes to the database.
        /// </remarks>
        public void SaveTV(TV tV)
        {
            context.TVs.Add(tV);
            context.SaveChanges();
        }
    }
}
