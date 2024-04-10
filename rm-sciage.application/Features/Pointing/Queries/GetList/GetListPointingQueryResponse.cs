using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Queries.GetList;

public class GetListPointingQueryResponse
{
    public List<PointingResponseDto> Pointings { get; set; } = [];
}