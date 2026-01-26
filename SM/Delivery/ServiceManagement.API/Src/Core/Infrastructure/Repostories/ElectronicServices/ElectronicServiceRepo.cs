

namespace _4EPlatForm.Infrastructure.Repostories.ElectronicServices
{
    public  class ElectronicServiceRepo :GRepository<ElectronicsServices>  , IElectronicServiceRepo
    {
        public ElectronicServiceRepo(DBContext context) : base(context)
        {
        }
    }
}
