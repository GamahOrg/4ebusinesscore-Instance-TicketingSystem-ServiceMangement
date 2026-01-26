

namespace _4EPlatForm.Infrastructure.Repostories.ServiceCatalogs
{
    public class ServiceCatalogTechnicionRepo : GRepository<ServiceCatalogTechnician> , IServiceCatalogTechnicionRepo
    {
        public ServiceCatalogTechnicionRepo(DBContext dBContext) : base(dBContext) { }

    }
}
