

namespace _4EPlatForm.Infrastructure.Repostories.ElectronicServices
{
    public class ElectronicsServicesMainclassiffcationRepo : GRepository<electronicsServicesMainclassiffcation> , IElectronicsServicesMainclassiffcationRepo
    { 
        public ElectronicsServicesMainclassiffcationRepo(DBContext context) : base(context)
        {
        }
    }
}
