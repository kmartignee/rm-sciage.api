using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.domain.Entities.Site;

public class SiteEntity : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int ZipCode { get; set; }
    public string Status { get; set; } = string.Empty;
    public ICollection<PointingEntity> Pointings { get; set; }
}