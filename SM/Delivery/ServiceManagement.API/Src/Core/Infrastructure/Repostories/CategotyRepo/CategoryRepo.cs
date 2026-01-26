

namespace _4EPlatForm.Infrastructure.Repostories.CategotyRepo
{
    public class CategoryRepo : GRepository<Category>, ICategoryRepo
    {
        public CategoryRepo(DBContext context) : base(context)
        {
        }
    }
}
