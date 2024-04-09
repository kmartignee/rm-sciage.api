using MediatR;

namespace rm_sciage.application.Features.Pointing.Queries.Get;

public class GetPointingQuery(Guid id) : IRequest<GetPointingQueryResponse>
{
    public Guid Id { get; set; } = id;
}