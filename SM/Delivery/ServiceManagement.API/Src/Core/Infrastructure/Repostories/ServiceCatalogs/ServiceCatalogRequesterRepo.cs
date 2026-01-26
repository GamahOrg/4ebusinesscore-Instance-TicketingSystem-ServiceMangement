

namespace _4EPlatForm.Infrastructure.Repostories.ServiceCatalogs
{
    public class ServiceCatalogRequesterRepo : GRepository<ServiceCatalogRequester> , IServiceCatalogRequesterRepo
    {
         public ServiceCatalogRequesterRepo (DBContext dBContext ) : base( dBContext ) { }
    }
}
