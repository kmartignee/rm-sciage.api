using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.Pointing.Commands.Create;
using rm_sciage.application.Features.Pointing.Queries.Get;
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
    public async Task<GetPointingQueryResponse> GetPointing(Guid id)
    {
        return await Mediator.Send(new GetPointingQuery(id));
    }
    
    [HttpGet("{userId:guid}/Week/{date:datetime}")]
    public async Task<GetListPointingQueryResponse> GetWeekPointings(Guid userId, DateTime date)
    {
        return await Mediator.Send(new GetListPointingQuery(userId, date));
    }
}