using Ardalis.Specification;
using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.application.Specification.Pointing;

public sealed class PointingByIdSpecification : Specification<PointingEntity>
{
    public PointingByIdSpecification(Guid id)
    {
        Query.Where(pointing => pointing.Id == id)
            .Include(pointing => pointing.Sites)
            .Include(pointing => pointing.Clockings);
    }
}