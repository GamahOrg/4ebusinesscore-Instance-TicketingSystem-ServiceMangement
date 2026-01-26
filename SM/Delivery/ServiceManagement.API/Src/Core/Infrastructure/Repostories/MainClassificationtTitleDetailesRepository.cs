namespace Infrastructure.Repostories
{
    public class MainClassificationtTitleDetailesRepository : GRepository<MainClassificationtTitleDetailes>, IMainClassificationtTitleDetailesRepository
    {
        public MainClassificationtTitleDetailesRepository(DBContext context) : base(context)
        {

        }
    }
}
