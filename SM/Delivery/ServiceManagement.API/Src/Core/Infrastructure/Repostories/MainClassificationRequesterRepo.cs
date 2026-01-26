

namespace _4EPlatForm.Infrastructure.Repostories
{
    public class MainClassificationRequesterRepo:GRepository<MainClassificationRequester>, IMainClassificationRequesterRepo

    {
        public MainClassificationRequesterRepo(DBContext context) : base(context)
        {

        }
    }
}
