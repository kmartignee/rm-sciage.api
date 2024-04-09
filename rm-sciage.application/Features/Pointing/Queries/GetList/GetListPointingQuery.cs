using MediatR;

namespace rm_sciage.application.Features.Pointing.Queries.GetList;

public class GetListPointingQuery(Guid id) : IRequest<GetListPointingQueryResponse>
{
    public Guid Id { get; set; } = id;
}