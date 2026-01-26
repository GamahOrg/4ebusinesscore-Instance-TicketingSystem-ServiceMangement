
namespace _4EPlatform.Domain.Models.MainClassificationModel
{
    public class MainClassificationRequester : BaseEntity<Guid>
    {
        public Guid RequesterId { get; set; }
        public Guid MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }
    }
}
