

namespace _4EPlatForm.Infrastructure.Repostories.Items
{
    public class itemTechnicianRepo : GRepository<ItemTechnician> , IitemTechnicianRepo
    {
        public itemTechnicianRepo(DBContext context) : base(context)
        {
        }
    }
}
