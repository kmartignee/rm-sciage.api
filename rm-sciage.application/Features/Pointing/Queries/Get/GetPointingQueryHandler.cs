using AutoMapper;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.application.Specification.Pointing;
using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Queries.Get;

public class GetPointingQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<GetPointingQuery, GetPointingQueryResponse>
{
    public async Task<GetPointingQueryResponse> Handle(GetPointingQuery request, CancellationToken cancellationToken)
    {
        var pointing =
            await unitOfWork.PointingRepository.FirstOrDefaultAsync(new PointingByIdSpecification(request.Id),
                cancellationToken);
        var a = mapper.Map<PointingResponseDto>(pointing);

        return new GetPointingQueryResponse { Pointing = a };
    }
}