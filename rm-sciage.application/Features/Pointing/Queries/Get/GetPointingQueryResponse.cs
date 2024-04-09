using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Queries.Get;

public abstract class GetPointingQueryResponse
{
    public PointingDto Pointing { get; set; } = new();
}