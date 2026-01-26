using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4EPlatform.Domain.Models.MainClassificationModel
{
    public class MainClassificationAdmins :BaseEntity<Guid>
    {
        public Guid AdminId { get; set; }
        public Guid MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }
    }
}
