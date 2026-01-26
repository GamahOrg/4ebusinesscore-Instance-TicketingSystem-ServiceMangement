

namespace _4EPlatform.Domain.Models.ServiceConfigurationModel
{
    public class ServiceConfiguration : BaseEntity<Guid>
    {
        public ServiceType ServiceType { get; set; }
        public string TeamName { get; set; }
    }
}
