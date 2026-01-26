namespace _4EPlatForm.Infrastructure.ModelsConfigurations.ItemsConfig
{
    internal class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasMany(a => a.ItemTechnicians)
                   .WithOne(b => b.Item)
                   .HasForeignKey(b => b.ItemId);

            builder.HasMany(a => a.ItemRequesters)
                   .WithOne(b => b.Item)
                   .HasForeignKey(b => b.ItemId);
            builder.Property(p => p.CanBeRequestedByAllUsers).HasDefaultValue(true);
        }
    }
}
