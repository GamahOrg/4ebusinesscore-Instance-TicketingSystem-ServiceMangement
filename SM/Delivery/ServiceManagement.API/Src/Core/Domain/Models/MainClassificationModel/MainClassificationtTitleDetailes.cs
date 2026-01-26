using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4EPlatform.Domain.Models.MainClassificationModel
{
    public class MainClassificationtTitleDetailes :BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string? TitleEn { get; set; }
        public string? TitleDescriptionEn { get; set; }
        public string TitleDescription { get; set; }
        public string MainClassificationDescription { get; set; }
        public string? MainClassificationDescriptionEn { get; set; }
        public string CatalogDescription { get; set; }
        public string? CatalogDescriptionEn { get; set; }
        public string CategoryDescription { get; set; }
        public string? CategoryDescriptionEn { get; set; }
        public string ItemDescription { get; set; }
        public string? ItemDescriptionEn { get; set; }
        public string SubjectDescription { get; set; }
        public string? SubjectDescriptionEn { get; set; }
        public bool? DefaultCheck { get; set; }
        public ServiceType ServiceType { get; set; }

        [ForeignKey("MainClassification")]
        public Guid? MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }
    }
}
