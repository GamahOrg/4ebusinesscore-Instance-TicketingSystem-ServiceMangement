

namespace _4EPlatForm.Infrastructure.Repostories.Items
{
    public class itemRequesterRepo : GRepository<ItemRequester> , IitemRequesterRepo
    {
        public itemRequesterRepo(DBContext context) : base(context)
        {
        }
    }
}
