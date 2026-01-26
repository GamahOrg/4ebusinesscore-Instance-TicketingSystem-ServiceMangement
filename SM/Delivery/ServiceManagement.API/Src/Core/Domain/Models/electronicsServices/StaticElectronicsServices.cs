using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4EPlatform.Domain.Models.electronicsServices
{
    public class StaticElectronicsServices:BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public long workspacekey { get; set; }
    }
}
