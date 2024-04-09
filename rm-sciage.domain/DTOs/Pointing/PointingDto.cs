namespace rm_sciage.domain.DTOs.Pointing;

public class PointingDto
{
    public List<Guid> SiteIds { get; set; } = [];
    public List<ClockingDto> Clockings { get; set; } = [];
    public bool IsDriver { get; set; }
    public string Description { get; set; } = string.Empty;
}