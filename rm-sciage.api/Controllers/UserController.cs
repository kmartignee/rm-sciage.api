using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.User.Commands.Create;
using rm_sciage.application.Features.User.Commands.Update;
using rm_sciage.application.Features.User.Queries.Get;
using rm_sciage.application.Features.User.Queries.GetList;
using rm_sciage.domain.DTOs.User;

namespace rm_sciage.api.Controllers;

public class UserController : ApiControllerBase<UserController>
{
    [HttpPost]
    public async Task<CreateUserCommandResponse> CreateUser(UserDto userDto)
    {
        return await Mediator.Send(new CreateUserCommand(userDto));
    }
    
    [HttpPut("{id:guid}")]
    public async Task<UpdateUserCommandResponse> UpdateUser(Guid id, UserDto userDto)
    {
        return await Mediator.Send(new UpdateUserCommand(id, userDto));
    }
    
    [HttpGet("{id:guid}")]
    public async Task<GetUserQueryResponse> GetUser(Guid id)
    {
        return await Mediator.Send(new GetUserQuery(id));
    }
    
    [HttpGet]
    public async Task<GetListUserQueryResponse> GetListUser()
    {
        return await Mediator.Send(new GetListUserQuery());
    }
}