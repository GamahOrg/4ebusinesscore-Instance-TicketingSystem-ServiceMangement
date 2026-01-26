

namespace _4EPlatForm.Infrastructure.Repostories
{
    public class MainClassificationAdminsRepo:GRepository<MainClassificationAdmins>, IMainClassificationAdminsRepo
    {
       public MainClassificationAdminsRepo(DBContext context) : base(context)
        {

        }
    }
}
