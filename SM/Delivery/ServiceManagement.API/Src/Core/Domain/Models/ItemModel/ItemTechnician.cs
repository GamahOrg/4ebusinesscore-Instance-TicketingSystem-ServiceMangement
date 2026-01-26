namespace _4EPlatform.Domain.Models.ItemModel
{
    public class ItemTechnician : BaseEntity<Guid>
    {
        public Guid TechnicianId { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        public long Index { get; set; }
    }
}
