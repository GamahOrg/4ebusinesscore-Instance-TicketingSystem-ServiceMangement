namespace _4EPlatform.Domain.Models.ItemModel
{
    public class Item : ServiceConfiguration
    {
        public string Name { get; set; }
        public string? NameEn { get; set; }
        public string Duration { get; set; }
        public TechnicianSelection TechnicianSelection { get; set; }
        public Effect? Effect { get; set; }
        public PriorityLevel PriorityLevel { get; set; }
        public Guid SlaId { get; set; }
        public string? Description { get; set; }
        public string? DescriptionEn { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string? DynamicForm { get; set; }
        public Guid RequestTemplateId { get; set; }
        public bool CanBeRequestedByAllUsers { get; set; } = false;
        public ICollection<ItemTechnician>? ItemTechnicians { get; set; }
        public ICollection<ItemRequester>? ItemRequesters { get; set; }
        public bool? IsIintegrated { get; set; }
        public Guid? WorkspaceServiceID { get; set; }
        public requestFor? requestFor { get; set; }
    }
}
