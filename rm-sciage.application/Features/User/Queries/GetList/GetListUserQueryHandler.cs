using MediatR;

namespace rm_sciage.application.Features.User.Queries.GetList;

public class GetListUserQueryHandler : IRequestHandler<GetListUserQuery, GetListUserQueryResponse>
{
    public Task<GetListUserQueryResponse> Handle(GetListUserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}