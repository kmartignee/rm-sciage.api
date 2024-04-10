namespace rm_sciage.domain.DTOs.Pointing;

public class ClockingDto
{
    public bool IsAm { get; set; }
    public string ArrivalTime { get; set; } = string.Empty;
    public string DepartureTime { get; set; } = string.Empty;
}