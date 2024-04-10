using AutoMapper;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.application.Specification.Pointing;
using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Queries.GetList;

public class GetListPointingQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetListPointingQuery, GetListPointingQueryResponse>
{
    public async Task<GetListPointingQueryResponse> Handle(GetListPointingQuery request,
        CancellationToken cancellationToken)
    {
        var firstDayOfWeek = request.Date.AddDays(-(int) request.Date.DayOfWeek + (int) DayOfWeek.Monday);
        var lastDayOfWeek = firstDayOfWeek.AddDays(6);
        
        var pointings =
            await unitOfWork.PointingRepository.ListAsync(
                new PointingsByUserIdAndDateRangeSpecification(request.Id, firstDayOfWeek, lastDayOfWeek), cancellationToken);

        return new GetListPointingQueryResponse { Pointings = mapper.Map<List<PointingResponseDto>>(pointings) };
    }
}