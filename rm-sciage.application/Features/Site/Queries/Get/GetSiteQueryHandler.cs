using MediatR;

namespace rm_sciage.application.Features.Site.Queries.Get;

public class GetSiteQueryHandler : IRequestHandler<GetSiteQuery, GetSiteQueryResponse>
{
    public Task<GetSiteQueryResponse> Handle(GetSiteQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}