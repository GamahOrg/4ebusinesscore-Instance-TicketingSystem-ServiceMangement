

namespace _4EPlatForm.Infrastructure.Repostories.CategotyRepo
{
    public class CategoryTechnicianRepo :GRepository<CategoryTechnician> , ICategoryTechnicianRepo
    {
        public CategoryTechnicianRepo(DBContext context) : base(context)
        {
        }
    }
}
