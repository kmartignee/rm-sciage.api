using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Queries.GetList;

public abstract class GetListSiteQueryResponse
{
    public List<SiteDto> Sites { get; set; } = [];
}