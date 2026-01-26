

namespace _4EPlatform.Domain.Models.CategoryModel
{
    public class CategoryRequester : BaseEntity<Guid>
    {
        public Guid RequesterId { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
