
namespace _4EPlatForm.Infrastructure.Repostories.ElectronicServices
{
    public class StaticElectronicsServicesRepo : GRepository<StaticElectronicsServices>, IStaticElectronicsServicesRepo
    {
        public StaticElectronicsServicesRepo(DBContext context) : base(context)
        {
        }
    }
}
