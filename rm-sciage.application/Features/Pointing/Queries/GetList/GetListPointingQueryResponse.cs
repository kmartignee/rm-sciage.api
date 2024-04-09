using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Queries.GetList;

public abstract class GetListPointingQueryResponse
{
    public List<PointingDto> Pointings { get; set; } = [];
}