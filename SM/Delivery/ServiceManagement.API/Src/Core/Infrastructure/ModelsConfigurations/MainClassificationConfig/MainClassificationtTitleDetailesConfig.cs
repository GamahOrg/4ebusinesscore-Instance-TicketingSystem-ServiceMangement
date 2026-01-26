namespace _4EPlatForm.Infrastructure.ModelsConfigurations.MainClassificationConfig
{
    internal class MainClassificationtTitleDetailesConfig : IEntityTypeConfiguration<MainClassificationtTitleDetailes>
    {
        public void Configure(EntityTypeBuilder<MainClassificationtTitleDetailes> builder)
        {

            builder.Property(x => x.MainClassificationId).IsRequired(false);
            builder.HasOne<MainClassification>(c => c.MainClassification)
              .WithMany(q => q.MainClassificationtTitleDetailes)
             .HasForeignKey(q => q.MainClassificationId);
        }
    }
}
