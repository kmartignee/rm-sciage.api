using MediatR;

namespace rm_sciage.application.Features.Pointing.Queries.GetList;

public class GetListPointingQuery(Guid id, DateTime date) : IRequest<GetListPointingQueryResponse>
{
    public Guid Id { get; set; } = id;
    public DateTime Date { get; set; } = date;
}