using _4EPlatform.Infrastructure.ModelsConfigurations.electronicsServicesconfig;

namespace Infrastructure.Context
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DBContext()
        {

        }
        public DbSet<StaticElectronicsServices> StaticElectronicsServices { get; set; }
        public DbSet<MainClassification> MainClassifications { get; set; }
        public DbSet<ServiceCatalog> ServiceCatalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MainClassificationTechnician> MainClassificationTechnicians { get; set; }
        public DbSet<MainClassificationRequester> MainClassificationRequesters { get; set; }
        public DbSet<MainClassificationAdmins> MainClassificationAdmins { get; set; }

        public DbSet<ServiceCatalogTechnician> ServiceCatalogTechnicians { get; set; }
        public DbSet<ServiceCatalogRequester> ServiceCatalogRequesters { get; set; }
        public DbSet<CategoryTechnician> CategoryTechnicians { get; set; }
        public DbSet<CategoryRequester> CategoryRequesters { get; set; }
        public DbSet<ItemTechnician> ItemTechnicians { get; set; }
        public DbSet<ItemRequester> ItemRequesters { get; set; }

        public DbSet<ElectronicsServices> ElectronicsServices { get; set; }
        public DbSet<electronicsServicesMainclassiffcation> electronicsServicesMainclassiffcation { get; set; }
        public DbSet<MainClassificationtTitleDetailes> MainClassificationtTitleDetailes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainClassificationConfig).Assembly);
            //modelBuilder.ApplyConfiguration(new ElectronicsServicesMainclassiffcationConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        }
        public bool AllMigrationsApplied()
        {
            var applied = this.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = this.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
        public void Migrate()
        {
            this.Database.Migrate();
        }
    }
}