namespace _4EPlatForm.Infrastructure.ModelsConfigurations.CategoriesConfig
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(a => a.Items)
                   .WithOne(a => a.Category)
                   .HasForeignKey(a => a.CategoryId);

            builder.HasMany(a => a.CategoryTechnicians)
                   .WithOne(b => b.Category)
                   .HasForeignKey(b => b.CategoryId);

            builder.HasMany(a => a.CategoryRequesters)
                   .WithOne(b => b.Category)
                   .HasForeignKey(b => b.CategoryId);

            builder.HasMany(a => a.SubCategories)
                   .WithOne(b => b.ParentCategory)
                   .HasForeignKey(b => b.ParentCategoryId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
