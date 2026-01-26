namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DBContext _dbContext;
        private IDbContextTransaction _transaction;
        IServiceProvider _serviceProvider;
        public Guid _loggedInUserId;
        public UnitOfWork(DBContext dbContext, IServiceProvider serviceProvider, IHttpContextAccessor _httpContextAccessor)
        {
            _dbContext = dbContext;
            _serviceProvider = serviceProvider;
            _loggedInUserId = LoggedInUserProvider.GetLoggedInUserId(_httpContextAccessor);
        }

        #region initialize
        IMainClassificationRepository mainClassification = null;
        IMainClassificationTechnicianRepository mainClassificationTechnician = null;
        IMainClassificationRequesterRepo mainClassificationRequester = null;
        IMainClassificationAdminsRepo mainClassificationAdmins = null;
        ICategoryRepo category = null;
        ICategoryRequesterRepo categoryRequester = null;
        ICategoryTechnicianRepo categoryTechnician = null;
        IElectronicServiceRepo electronicService = null;
        IElectronicsServicesMainclassiffcationRepo electronicsServicesMainclassiffcation = null;
        IStaticElectronicsServicesRepo staticElectronicsServices = null;
        IitemRepo item = null;
        IitemRequesterRepo itemRequester = null;
        IitemTechnicianRepo itemTechnician = null;
        IServiceCatalogRepo serviceCatalog = null;
        IServiceCatalogRequesterRepo serviceCatalogRequester = null;
        IServiceCatalogTechnicionRepo serviceCatalogTechnicion = null;
        IMainClassificationtTitleDetailesRepository mainClassificationtTitleDetailes = null;
        #endregion

        #region service catalog
        public IServiceCatalogTechnicionRepo ServiceCatalogTechnician
        {
            get
            {
                return serviceCatalogTechnicion ?? _serviceProvider.GetService<IServiceCatalogTechnicionRepo>();
            }
        }
        public IServiceCatalogRequesterRepo ServiceCatalogRequester
        {
            get
            {
                return serviceCatalogRequester ?? _serviceProvider.GetService<IServiceCatalogRequesterRepo>();
            }
        }
        public IServiceCatalogRepo ServiceCatalog
        {
            get
            {
                return serviceCatalog ?? _serviceProvider.GetService<IServiceCatalogRepo>();
            }
        }
        #endregion

        #region Item
        public IitemTechnicianRepo ItemTechnician
        {
            get
            {
                return itemTechnician ?? _serviceProvider.GetService<IitemTechnicianRepo>();
            }
        }
        public IitemRequesterRepo ItemRequester
        {
            get
            {
                return itemRequester ?? _serviceProvider.GetService<IitemRequesterRepo>();
            }
        }
        public IitemRepo Item
        {
            get
            {
                return item ?? _serviceProvider.GetService<IitemRepo>();
            }
        }
        #endregion

        #region ElectronicServices
        public IStaticElectronicsServicesRepo StaticElectronicsServices
        {
            get
            {
                return staticElectronicsServices ?? _serviceProvider.GetService<IStaticElectronicsServicesRepo>();
            }
        }
        public IElectronicsServicesMainclassiffcationRepo ElectronicsServicesMainclassiffcation
        {
            get
            {
                return electronicsServicesMainclassiffcation ?? _serviceProvider.GetService<IElectronicsServicesMainclassiffcationRepo>();
            }
        }
        public IElectronicServiceRepo ElectronicService
        {
            get
            {
                return electronicService ?? _serviceProvider.GetService<IElectronicServiceRepo>();
            }
        }
        #endregion

        #region Category
        public ICategoryTechnicianRepo CategoryTechnician
        {
            get
            {
                return categoryTechnician ?? _serviceProvider.GetService<ICategoryTechnicianRepo>();
            }
        }
        public ICategoryRequesterRepo CategoryRequester
        {
            get
            {
                return categoryRequester ?? _serviceProvider.GetService<ICategoryRequesterRepo>();
            }
        }
        public ICategoryRepo Category
        {
            get
            {
                return category ?? _serviceProvider.GetService<ICategoryRepo>();
            }
        }
        #endregion

        #region MainClassifications
        public IMainClassificationAdminsRepo MainClassificationAdmins
        {
            get
            {
                return mainClassificationAdmins ?? _serviceProvider.GetService<IMainClassificationAdminsRepo>();
            }
        }
        public IMainClassificationtTitleDetailesRepository MainClassificationtTitleDetailes
        {
            get
            {
                return mainClassificationtTitleDetailes ?? _serviceProvider.GetService<IMainClassificationtTitleDetailesRepository>();
            }
        }
        public IMainClassificationRequesterRepo MainClassificationRequester
        {
            get
            {
                return mainClassificationRequester ?? _serviceProvider.GetService<IMainClassificationRequesterRepo>();
            }
        }
        public IMainClassificationRepository MainClassification
        {
            get
            {
                return mainClassification ?? _serviceProvider.GetService<IMainClassificationRepository>();
            }
        }
        public IMainClassificationTechnicianRepository MainClassificationTechnician
        {
            get
            {
                return mainClassificationTechnician ?? _serviceProvider.GetService<IMainClassificationTechnicianRepository>();
            }
        }
        #endregion

        #region Transaction
        public void BeginTransaction() => _transaction = _dbContext.Database.BeginTransaction();
        public async Task BeginTransactionAsync() => _transaction = await _dbContext.Database.BeginTransactionAsync();
        public void Commit() => _transaction.Commit();
        public async Task CommitAsync() => await _transaction.CommitAsync();
        public void Rollback() => _transaction?.Rollback();
        public async Task RollbackAsync() => await _transaction.RollbackAsync();

        public void Dispose()
        {
            _transaction?.Dispose();
            _dbContext.Dispose();
        }
        public async Task DisposeAsync()
        {
            await _transaction.DisposeAsync();
            await _dbContext.DisposeAsync();
        }
        #endregion

        #region SaveChanges
        public void SaveChanges()
        {
            try
            {
                var entries = _dbContext.ChangeTracker.Entries()
                    .Where(e => (e.Entity is BaseEntity<Guid>) && (e.State == EntityState.Added || e.State == EntityState.Modified));

                foreach (var entityEntry in entries)
                {
                    if (entityEntry.State == EntityState.Modified)
                    {
                        ((BaseEntity<Guid>)entityEntry.Entity).UpdatedOn = DateTime.Now;
                        ((BaseEntity<Guid>)entityEntry.Entity).UpdatedBy = _loggedInUserId;
                        entityEntry.Property("CreatedOn").IsModified = false;
                        entityEntry.Property("CreatedBy").IsModified = false;
                    }

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity<Guid>)entityEntry.Entity).CreatedOn = DateTime.Now;
                        ((BaseEntity<Guid>)entityEntry.Entity).CreatedBy = _loggedInUserId;
                    }

                }
                if (_dbContext.Database.CurrentTransaction == null)
                    BeginTransaction();
                _dbContext.SaveChanges();
                //Commit();
            }
            catch (Exception ex)
            {
                Rollback();
                throw ex;

            }

        }

        public async Task SaveChangesAsync()
        {
            try
            {

                var entries = _dbContext.ChangeTracker.Entries()
.Where(e => (e.Entity is BaseEntity<Guid>) && (
     e.State == EntityState.Added
     || e.State == EntityState.Modified));

                foreach (var entityEntry in entries)
                {
                    if (entityEntry.State == EntityState.Modified)
                    {
                        ((BaseEntity<Guid>)entityEntry.Entity).UpdatedOn = DateTime.Now;
                        //((BaseEntity<Guid>)entityEntry.Entity).UpdatedBy = _loggedInUserId;
                        entityEntry.Property("CreatedOn").IsModified = false;
                        entityEntry.Property("CreatedBy").IsModified = false;


                    }

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity<Guid>)entityEntry.Entity).CreatedOn = DateTime.Now;
                        //((BaseEntity<Guid>)entityEntry.Entity).CreatedBy = _loggedInUserId;
                    }
                }
                if (_dbContext.Database.CurrentTransaction == null)
                    await BeginTransactionAsync();
                await _dbContext.SaveChangesAsync();
                //Commit();
            }
            catch (Exception)
            {
                await RollbackAsync();

            }

        }
        #endregion


    }
}
