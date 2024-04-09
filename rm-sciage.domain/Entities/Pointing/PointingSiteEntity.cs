using rm_sciage.domain.Entities.Site;

namespace rm_sciage.domain.Entities.Pointing;

public class PointingSiteEntity
{
    public Guid PointingId { get; set; }
    public PointingEntity Pointing { get; set; }
    public Guid SiteId { get; set; }
    public SiteEntity Site { get; set; }
}