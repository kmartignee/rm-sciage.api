using MediatR;

namespace rm_sciage.application.Features.Site.Queries.GetList;

public class GetListSiteQueryHandler : IRequestHandler<GetListSiteQuery, GetListSiteQueryResponse>
{
    public Task<GetListSiteQueryResponse> Handle(GetListSiteQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}