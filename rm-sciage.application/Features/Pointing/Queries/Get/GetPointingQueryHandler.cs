using MediatR;

namespace rm_sciage.application.Features.Pointing.Queries.Get;

public class GetPointingQueryHandler : IRequestHandler<GetPointingQuery, GetPointingQueryResponse>
{
    public Task<GetPointingQueryResponse> Handle(GetPointingQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}