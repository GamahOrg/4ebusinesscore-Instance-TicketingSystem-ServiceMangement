
namespace Infrastructure.Repostories
{
    public class MainClassificationRepository : GRepository<MainClassification>, IMainClassificationRepository
    {
        public MainClassificationRepository(DBContext context) : base(context)
        {

        }
    }
}
