
using _4EPlatForm.Infrastructure.Contracts;
using _4EPlatForm.Infrastructure.Contracts.ServicCatalogs;
using Infrastructure.Repostories;

namespace _4EPlatForm.Infrastrucure.Extention
{
    public static class DIExtension
    {
        public static void AddUnitOfWorkRepositry(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMainClassificationRepository, MainClassificationRepository>();
            services.AddScoped<IMainClassificationTechnicianRepository, MainClassificationTechnicianRepository>();
            services.AddScoped<IMainClassificationRequesterRepo, MainClassificationRequesterRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<ICategoryRequesterRepo, CategoryRequesterRepo>();
            services.AddScoped<ICategoryTechnicianRepo, CategoryTechnicianRepo>();
            services.AddScoped<IElectronicServiceRepo, ElectronicServiceRepo>();
            services.AddScoped<IElectronicsServicesMainclassiffcationRepo, ElectronicsServicesMainclassiffcationRepo>();
            services.AddScoped<IStaticElectronicsServicesRepo, StaticElectronicsServicesRepo>();
            services.AddScoped<IitemRepo, ItemRepo>();
            services.AddScoped<IitemRequesterRepo, itemRequesterRepo>();
            services.AddScoped<IitemTechnicianRepo, itemTechnicianRepo>();
            services.AddScoped<IServiceCatalogRepo, ServiceCatalogRepo>();
            services.AddScoped<IServiceCatalogRequesterRepo, ServiceCatalogRequesterRepo>();
            services.AddScoped<IServiceCatalogTechnicionRepo, ServiceCatalogTechnicionRepo>();
            services.AddScoped<IMainClassificationtTitleDetailesRepository, MainClassificationtTitleDetailesRepository>();







        }
    }
}
