using AutoMapper;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Queries.GetList;

public class GetListSiteQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetListSiteQuery, GetListSiteQueryResponse>
{
    public async Task<GetListSiteQueryResponse> Handle(GetListSiteQuery request, CancellationToken cancellationToken)
    {
        var sites = await unitOfWork.SiteRepository.ListAllAsync(cancellationToken);
        
        return new GetListSiteQueryResponse { Sites = mapper.Map<List<SiteResponseDto>>(sites) };
    }
}