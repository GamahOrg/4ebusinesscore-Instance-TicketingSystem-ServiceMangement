

namespace _4EPlatForm.Infrastructure.Repostories.Items
{
    public class ItemRepo : GRepository<Item>, IitemRepo
    {
        public ItemRepo(DBContext context) : base(context)
        {
        }
    }
}
