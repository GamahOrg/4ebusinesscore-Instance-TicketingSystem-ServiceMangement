

namespace _4EPlatform.Domain.Models.ServiceCatalogModel
{
    public class ServiceCatalogRequester : BaseEntity<Guid>
    {
        public Guid RequesterId { get; set; }
        public Guid ServiceCatalogId { get; set; }
        public ServiceCatalog ServiceCatalog { get; set; }
    }
}
