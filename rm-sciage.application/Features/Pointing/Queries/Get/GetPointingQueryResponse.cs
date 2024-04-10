using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Queries.Get;

public class GetPointingQueryResponse
{
    public PointingResponseDto Pointing { get; set; } = new();
}