using MediatR;

namespace rm_sciage.application.Features.Site.Queries.Get;

public class GetSiteQuery(Guid guid) : IRequest<GetSiteQueryResponse>
{
    public Guid Id { get; set; } = guid;
}