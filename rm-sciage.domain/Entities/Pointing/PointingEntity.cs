using rm_sciage.domain.Entities.Site;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.domain.Entities.Pointing;

public class PointingEntity : EntityBase
{
    public Guid UserId { get; set; }
    public UserEntity User { get; set; }
    public ICollection<SiteEntity> Sites { get; set; }
    public DateTime Date { get; set; }
    public ICollection<ClockingEntity> Clockings { get; set; }
    public bool IsDriver { get; set; }
    public string Description { get; set; } = string.Empty;
}