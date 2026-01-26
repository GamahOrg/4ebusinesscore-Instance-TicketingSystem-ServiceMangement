namespace _4EPlatform.Domain.Models.ItemModel
{
    public class ItemRequester : BaseEntity<Guid>
    {
        public Guid RequesterId { get; set; }
        public Guid ItemId { get; set; }
        public string? RequesterForm { get; set; }
        public Item Item { get; set; }
    }
}
