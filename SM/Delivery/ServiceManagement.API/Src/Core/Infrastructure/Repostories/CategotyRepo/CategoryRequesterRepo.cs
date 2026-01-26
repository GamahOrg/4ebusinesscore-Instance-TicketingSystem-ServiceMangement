

namespace _4EPlatForm.Infrastructure.Repostories.CategotyRepo
{
    public class CategoryRequesterRepo : GRepository<CategoryRequester> , ICategoryRequesterRepo
    {
        public CategoryRequesterRepo(DBContext context) : base(context)
        {
        }
    }
}
