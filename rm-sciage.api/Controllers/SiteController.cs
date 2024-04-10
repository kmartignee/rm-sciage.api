using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.Site.Commands.Create;
using rm_sciage.application.Features.Site.Commands.Update;
using rm_sciage.application.Features.Site.Queries.Get;
using rm_sciage.application.Features.Site.Queries.GetList;
using rm_sciage.domain.DTOs.Site;
using Swashbuckle.AspNetCore.Annotations;

namespace rm_sciage.api.Controllers;

public class SiteController : ApiControllerBase<SiteController>
{
    [HttpPost]
    [SwaggerOperation(Summary = "Créer un chantier.",
        Description = "Créer un chantier en fonction des informations données.")]
    public async Task<CreateSiteCommandResponse> CreateSite(SiteDto siteDto)
    {
        return await Mediator.Send(new CreateSiteCommand(siteDto));
    }
    
    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Met à jour un chantier.",
        Description = "Met à jour un chantier en fonction des informations données.")]
    public async Task<UpdateSiteCommandResponse> UpdateSite(Guid id, SiteDto siteDto)
    {
        return await Mediator.Send(new UpdateSiteCommand(id, siteDto));
    }
    
    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Récupère un chantier.",
        Description = "Récupère un chantier en fonction de son identifiant.")]
    public async Task<GetSiteQueryResponse> GetSite(Guid id)
    {
        return await Mediator.Send(new GetSiteQuery(id));
    }
    
    [HttpGet]
    [SwaggerOperation(Summary = "Récupère la liste des chantiers.",
        Description = "Récupère la liste des chantiers.")]
    public async Task<GetListSiteQueryResponse> GetListSite()
    {
        return await Mediator.Send(new GetListSiteQuery());
    }
}