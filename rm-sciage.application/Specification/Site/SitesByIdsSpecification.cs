using Ardalis.Specification;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.application.Specification.Site;

public sealed class SitesByIdsSpecification : Specification<SiteEntity>
{
    public SitesByIdsSpecification(IEnumerable<Guid> ids)
    {
        Query.Where(site => ids.Contains(site.Id));
    }
}