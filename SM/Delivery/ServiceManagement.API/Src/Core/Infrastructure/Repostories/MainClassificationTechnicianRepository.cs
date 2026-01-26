
namespace Infrastructure.Repostories
{
    public class MainClassificationTechnicianRepository : GRepository<MainClassificationTechnician>, IMainClassificationTechnicianRepository
    {
        public MainClassificationTechnicianRepository(DBContext context) : base(context)
        {

        }
    }
}
