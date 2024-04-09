using MediatR;

namespace rm_sciage.application.Features.Pointing.Queries.GetList;

public class GetListPointingQueryHandler : IRequestHandler<GetListPointingQuery, GetListPointingQueryResponse>
{
    public Task<GetListPointingQueryResponse> Handle(GetListPointingQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}