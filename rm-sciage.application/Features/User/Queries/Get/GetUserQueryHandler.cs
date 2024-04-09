using MediatR;

namespace rm_sciage.application.Features.User.Queries.Get;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserQueryResponse>
{
    public Task<GetUserQueryResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}