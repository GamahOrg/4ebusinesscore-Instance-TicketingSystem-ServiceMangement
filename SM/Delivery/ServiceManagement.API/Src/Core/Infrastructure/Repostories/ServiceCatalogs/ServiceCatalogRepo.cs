

namespace _4EPlatForm.Infrastructure.Repostories.ServiceCatalogs
{
    public class ServiceCatalogRepo : GRepository<ServiceCatalog> , IServiceCatalogRepo
    {
        public ServiceCatalogRepo(DBContext context) : base(context)
        {
        }
    }
}
