using _4EPlatform.Domain.Models.electronicsServices;

namespace _4EPlatform.Domain.Models.MainClassificationModel
{
    public class MainClassification : ServiceConfiguration
    {
        public string Name { get; set; }
        public string? NameEn { get; set; }
        public Guid OrgId { get; set; }

     //   public Guid Admin { get; set; }
        public string? Icon { get; set; }
        public string? Code { get; set; }
        public string? Color { get; set; }
        public string? Kpi { get; set; }
        public Guid? SubSystemMainClassificationId { get; set; }

        public Guid? SubSystemId{ get; set; }

        public Guid? SubSystemMainClassificationLookupId { get; set; }

        public int? Sequence { get; set; }
        public int? SubsystemSequnce { get; set; }

        public int? SubsystemmainSequnce { get; set; }


        public string? Description { get; set; }
        public string? DescriptionEn { get; set; }
        public bool CanBeRequestedByAllUsers { get; set; } = false;
        public bool? IsShowInHomePage { get; set; }
        public ICollection<ServiceCatalog>? ServiceCatalogs { get; set; }
        public ICollection<MainClassificationTechnician>? MainClassificationTechnicians { get; set; }
        public ICollection<MainClassificationAdmins>? MainClassificationAdmin { get; set; }

        public ICollection<MainClassificationRequester>? MainClassificationRequesters { get; set; }
        public ICollection<electronicsServicesMainclassiffcation>? electronicsServicesMainclassiffcations { get; set; } // Add this line
        public List<MainClassificationtTitleDetailes> MainClassificationtTitleDetailes { get; set; }
    }
}

