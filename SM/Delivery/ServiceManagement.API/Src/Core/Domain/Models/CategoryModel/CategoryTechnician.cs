
namespace _4EPlatform.Domain.Models.CategoryModel
{
    public class CategoryTechnician : BaseEntity<Guid>
    {
        public Guid TechnicianId { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
