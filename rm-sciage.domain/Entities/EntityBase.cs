namespace rm_sciage.domain.Entities;

public class EntityBase : IEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}