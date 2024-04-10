using AutoMapper;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Queries.Get;

public class GetSiteQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetSiteQuery, GetSiteQueryResponse>
{
    public async Task<GetSiteQueryResponse> Handle(GetSiteQuery request, CancellationToken cancellationToken)
    {
        var site = await unitOfWork.SiteRepository.GetByIdAsync(request.Id, cancellationToken);
        
        return new GetSiteQueryResponse { Site = mapper.Map<SiteResponseDto>(site) };
    }
}