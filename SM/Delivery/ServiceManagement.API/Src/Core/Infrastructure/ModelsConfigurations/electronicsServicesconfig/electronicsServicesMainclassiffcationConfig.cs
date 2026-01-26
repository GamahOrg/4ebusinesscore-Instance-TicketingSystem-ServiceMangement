

namespace _4EPlatform.Infrastructure.ModelsConfigurations.electronicsServicesconfig
{
    public class ElectronicsServicesMainclassiffcationConfig : IEntityTypeConfiguration<electronicsServicesMainclassiffcation>
    {
        public void Configure(EntityTypeBuilder<electronicsServicesMainclassiffcation> builder)
        {
            // Composite Key
            builder.HasKey(e => new { e.MainClassificationId, e.electronicsServicesId });

            // Relationships
            builder.HasOne(e => e.MainClassification)
                .WithMany(m => m.electronicsServicesMainclassiffcations)
                .HasForeignKey(e => e.MainClassificationId);

            builder.HasOne(e => e.electronicsServices)
                .WithMany(es => es.electronicsServicesMainclassiffcations)
                .HasForeignKey(e => e.electronicsServicesId);
        }
    }
}
