namespace _4EPlatform.Domain.Models.electronicsServices
{
    public class ElectronicsServices : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public long workspacekey { get; set; }
        public bool Ischecked { get; set; }
        public ICollection<electronicsServicesMainclassiffcation>? electronicsServicesMainclassiffcations { get; set; } // Add this line
    }
}
