namespace rm_sciage.domain.Entities.Pointing;

public class ClockingEntity : EntityBase
{
    public bool IsAm { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public TimeSpan DepartureTime { get; set; }
    public Guid PointingId { get; set; }
    public PointingEntity Pointing { get; set; }
}