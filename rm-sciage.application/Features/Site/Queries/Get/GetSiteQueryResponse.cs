using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Queries.Get;

public class GetSiteQueryResponse
{
    public SiteDto Site { get; set; } = new();
}