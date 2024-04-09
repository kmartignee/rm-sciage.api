using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.Pointing.Commands.Create;
using rm_sciage.application.Features.Pointing.Queries.GetList;
using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.api.Controllers;

public class PointingController : ApiControllerBase<PointingController>
{
    [HttpPost]
    public async Task<CreatePointingCommandResponse> GetPointing(PointingDto pointingDto)
    {
        return await Mediator.Send(new CreatePointingCommand(pointingDto));
    }
    
    [HttpGet("{id:guid}")]
    public async Task<GetListPointingQueryResponse> GetPointing(Guid id)
    {
        return await Mediator.Send(new GetListPointingQuery(id));
    }
    
    [HttpGet("{id:guid}/Week")]
    public async Task<GetListPointingQueryResponse> GetWeekPointings(Guid id)
    {
        return await Mediator.Send(new GetListPointingQuery(id));
    }
}