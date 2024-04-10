using Ardalis.Specification;
using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.application.Specification.Pointing;

public sealed class PointingsByUserIdAndDateRangeSpecification : Specification<PointingEntity>
{
    public PointingsByUserIdAndDateRangeSpecification(Guid userId, DateTime startDate, DateTime endDate)
    {
        Query.Where(pointing => pointing.UserId == userId && pointing.Date.Date >= startDate.Date && pointing.Date.Date <= endDate.Date)
            .Include(pointing => pointing.Sites)
            .Include(pointing => pointing.Clockings);
    }
}