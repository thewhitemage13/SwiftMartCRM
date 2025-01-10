using SwiftMart.DataBase;
using SwiftMartCRM.ProductEntity;

namespace SwiftMartCRM.Services
{
    public class TVService
    {
        private readonly Context context;

        public TVService()
        {
            context = new Context();
        }

        public void SaveTV(TV tV)
        {
            context.TVs.Add(tV);
            context.SaveChanges();
        }
    }
}
