using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.Pointing.Commands.Create;
using rm_sciage.application.Features.Pointing.Queries.Get;
using rm_sciage.application.Features.Pointing.Queries.GetList;
using rm_sciage.domain.DTOs.Pointing;
using Swashbuckle.AspNetCore.Annotations;

namespace rm_sciage.api.Controllers;

public class PointingController : ApiControllerBase<PointingController>
{
    [HttpPost]
    [SwaggerOperation(Summary = "Créer un pointage.",
        Description = "Créer un pointage en fonction des informations données.")]
    public async Task<CreatePointingCommandResponse> GetPointing(PointingDto pointingDto)
    {
        return await Mediator.Send(new CreatePointingCommand(pointingDto));
    }
    
    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Récupère un pointage.",
        Description = "Récupère un pointage en fonction de son identifiant.")]
    public async Task<GetPointingQueryResponse> GetPointing(Guid id)
    {
        return await Mediator.Send(new GetPointingQuery(id));
    }
    
    [HttpGet("{userId:guid}/Week/{date:datetime}")]
    [SwaggerOperation(Summary = "Récupère les pointages de la semaine de l'utilisateur.",
        Description = "Récupère les pointages de la semaine de l'utilisateur. A partir de la date donnée, on récupère le lundi de la semaine et on récupère les pointages de la semaine.")]
    public async Task<GetListPointingQueryResponse> GetWeekPointings(Guid userId, DateTime date)
    {
        return await Mediator.Send(new GetListPointingQuery(userId, date));
    }
}