using System;
using _4EPlatform.Domain.Models.MainClassificationModel;

namespace _4EPlatform.Domain.Models.electronicsServices
{
    public class electronicsServicesMainclassiffcation : BaseEntity<Guid>
    {
        public Guid MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }

        public Guid electronicsServicesId { get; set; }
        public ElectronicsServices electronicsServices { get; set; }
    }
}
