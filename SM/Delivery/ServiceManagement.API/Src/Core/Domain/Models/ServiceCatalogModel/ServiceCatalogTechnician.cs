

namespace _4EPlatform.Domain.Models.ServiceCatalogModel
{
    public class ServiceCatalogTechnician : BaseEntity<Guid>
    {
        public Guid TechnicianId { get; set; }
        public Guid ServiceCatalogId { get; set; }
        public ServiceCatalog ServiceCatalog { get; set; }
    }
}
