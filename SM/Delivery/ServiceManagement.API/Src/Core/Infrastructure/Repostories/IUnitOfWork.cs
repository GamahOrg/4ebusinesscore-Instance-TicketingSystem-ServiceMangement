namespace Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        #region Mainclassifications 
        IMainClassificationRepository MainClassification { get; }
        IMainClassificationTechnicianRepository MainClassificationTechnician { get; }
        IMainClassificationRequesterRepo MainClassificationRequester { get; }
        IMainClassificationAdminsRepo MainClassificationAdmins { get; }
        IMainClassificationtTitleDetailesRepository MainClassificationtTitleDetailes { get; }
        #endregion

        #region Categories
        ICategoryRepo Category { get; }
        ICategoryRequesterRepo CategoryRequester { get; }
        ICategoryTechnicianRepo CategoryTechnician { get; }
        #endregion

        #region ElectronicsServices
        IElectronicServiceRepo ElectronicService { get; }
        IElectronicsServicesMainclassiffcationRepo ElectronicsServicesMainclassiffcation { get; }
        IStaticElectronicsServicesRepo StaticElectronicsServices { get; }
        #endregion

        #region Items
        IitemRepo Item { get; }
        IitemRequesterRepo ItemRequester { get; }
        IitemTechnicianRepo ItemTechnician { get; }
        #endregion

        #region ServiceCatalogs
        IServiceCatalogRepo ServiceCatalog { get; }
        IServiceCatalogRequesterRepo ServiceCatalogRequester { get; }
        IServiceCatalogTechnicionRepo ServiceCatalogTechnician { get; }
        #endregion

        #region Transaction
        void BeginTransaction();
        void Commit();
        void Rollback();
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        #endregion

        #region SaveChanges
        Task SaveChangesAsync();
        void SaveChanges();
        #endregion
    }
}
