namespace _4EPlatForm.Infrastructure.ModelsConfigurations.MainClassificationConfig
{
    internal class MainClassificationConfig : IEntityTypeConfiguration<MainClassification>
    {
        public void Configure(EntityTypeBuilder<MainClassification> builder)
        {
            builder.HasMany(a => a.ServiceCatalogs)
                   .WithOne(b => b.MainClassification)
                   .HasForeignKey(b => b.MainClassificationId);

            builder.HasMany(a => a.MainClassificationTechnicians)
                   .WithOne(b => b.MainClassification)
                   .HasForeignKey(b => b.MainClassificationId);

            builder.HasMany(a => a.MainClassificationRequesters)
                   .WithOne(b => b.MainClassification)
                   .HasForeignKey(b => b.MainClassificationId);

            builder.HasMany(a => a.MainClassificationAdmin)
             .WithOne(b => b.MainClassification)
             .HasForeignKey(b => b.MainClassificationId);

        }
    }
}
