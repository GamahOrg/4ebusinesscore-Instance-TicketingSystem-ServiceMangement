
namespace _4EPlatform.Domain.Models.ServiceCatalogModel
{
    public class ServiceCatalog : ServiceConfiguration
    {
        public string Name { get; set; }
        public string? NameEn { get; set; }
        public Priority Priority { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string? DescriptionEn { get; set; }
        public Guid MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }
        public bool CanBeRequestedByAllUsers { get; set; } = false;
        public ICollection<Category>? Categories { get; set; }
        public ICollection<ServiceCatalogTechnician>? ServiceCatalogTechnicians { get; set; }
        public ICollection<ServiceCatalogRequester>? ServiceCatalogRequesters { get; set; }
    }
}
