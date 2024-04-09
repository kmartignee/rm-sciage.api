using MediatR;

namespace rm_sciage.application.Features.User.Queries.Get;

public class GetUserQuery(Guid guid) : IRequest<GetUserQueryResponse>
{
    public Guid Id { get; set; } = guid;
}