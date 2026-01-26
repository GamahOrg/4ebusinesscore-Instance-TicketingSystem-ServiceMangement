namespace _4EPlatForm.Infrastructure.ModelsConfigurations.ServiceCatalogConfig
{
    internal class ServiceCatalogConfig : IEntityTypeConfiguration<ServiceCatalog>
    {
        public void Configure(EntityTypeBuilder<ServiceCatalog> builder)
        {
            builder.HasMany(a => a.Categories)
                   .WithOne(b => b.ServiceCatalog)
                   .HasForeignKey(b => b.ServiceCatalogId);

            builder.HasMany(a => a.ServiceCatalogTechnicians)
                   .WithOne(b => b.ServiceCatalog)
                   .HasForeignKey(b => b.ServiceCatalogId);

            builder.HasMany(a => a.ServiceCatalogRequesters)
                   .WithOne(b => b.ServiceCatalog)
                   .HasForeignKey(b => b.ServiceCatalogId);
        }
    }
}
