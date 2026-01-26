

namespace _4EPlatform.Domain.Models.CategoryModel
{
    public class Category : ServiceConfiguration
    {
        public string Name { get; set; }
        public string? NameEn { get; set; }
        public CategoryStatus Status { get; set; }
        public Priority Priority { get; set; }
        public string? Description { get; set; }
        public string? DescriptionEn { get; set; }
        public Guid ServiceCatalogId { get; set; }
        public ServiceCatalog ServiceCatalog { get; set; }
        public Guid? ParentCategoryId { get; set; } = null;
        public Category ParentCategory { get; set; }
        public bool CanBeRequestedByAllUsers { get; set; } = false;
        public ICollection<Category>? SubCategories { get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<CategoryTechnician>? CategoryTechnicians { get; set; }
        public ICollection<CategoryRequester>? CategoryRequesters { get; set; }
    }
}
