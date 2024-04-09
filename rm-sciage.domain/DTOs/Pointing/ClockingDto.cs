namespace rm_sciage.domain.DTOs.Pointing;

public class ClockingDto
{
    public bool IsAm { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public TimeSpan DepartureTime { get; set; }
}