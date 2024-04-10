using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Queries.GetList;

public class GetListSiteQueryResponse
{
    public List<SiteResponseDto> Sites { get; set; } = [];
}