using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.Site.Commands.Create;
using rm_sciage.application.Features.Site.Commands.Update;
using rm_sciage.application.Features.Site.Queries.Get;
using rm_sciage.application.Features.Site.Queries.GetList;
using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.api.Controllers;

public class SiteController : ApiControllerBase<SiteController>
{
    [HttpPost]
    public async Task<CreateSiteCommandResponse> CreateSite(SiteDto siteDto)
    {
        return await Mediator.Send(new CreateSiteCommand(siteDto));
    }
    
    [HttpPut("{id:guid}")]
    public async Task<UpdateSiteCommandResponse> UpdateSite(Guid id, SiteDto siteDto)
    {
        return await Mediator.Send(new UpdateSiteCommand(id, siteDto));
    }
    
    [HttpGet("{id:guid}")]
    public async Task<GetSiteQueryResponse> GetSite(Guid id)
    {
        return await Mediator.Send(new GetSiteQuery(id));
    }
    
    [HttpGet]
    public async Task<GetListSiteQueryResponse> GetListSite()
    {
        return await Mediator.Send(new GetListSiteQuery());
    }
}