
namespace _4EPlatform.Domain.Models.MainClassificationModel
{
    public class MainClassificationTechnician : BaseEntity<Guid>
    {
        public Guid TechnicianId { get; set; }
        public Guid MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }
    }
}
