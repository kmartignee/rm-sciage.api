using Microsoft.AspNetCore.Mvc;
using rm_sciage.application.Features.User.Commands.Create;
using rm_sciage.application.Features.User.Commands.Delete;
using rm_sciage.application.Features.User.Commands.Update;
using rm_sciage.application.Features.User.Queries.Get;
using rm_sciage.application.Features.User.Queries.GetList;
using rm_sciage.domain.DTOs.User;
using Swashbuckle.AspNetCore.Annotations;

namespace rm_sciage.api.Controllers;

public class UserController : ApiControllerBase<UserController>
{
    [HttpPost]
    [SwaggerOperation(Summary = "Créer un utilisateur.",
        Description = "Créer un utilisateur en fonction des informations données.")]
    public async Task<CreateUserCommandResponse> CreateUser(UserDto userDto)
    {
        return await Mediator.Send(new CreateUserCommand(userDto));
    }
    
    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Met à jour un utilisateur.",
        Description = "Met à jour un utilisateur en fonction des informations données.")]
    public async Task<UpdateUserCommandResponse> UpdateUser(Guid id, UserDto userDto)
    {
        return await Mediator.Send(new UpdateUserCommand(id, userDto));
    }
    
    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Récupère un utilisateur.",
        Description = "Récupère un utilisateur en fonction de son identifiant.")]
    public async Task<GetUserQueryResponse> GetUser(Guid id)
    {
        return await Mediator.Send(new GetUserQuery(id));
    }
    
    [HttpGet]
    [SwaggerOperation(Summary = "Récupère la liste des utilisateurs.",
        Description = "Récupère la liste des utilisateurs.")]
    public async Task<GetListUserQueryResponse> GetListUser()
    {
        return await Mediator.Send(new GetListUserQuery());
    }
    
    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Supprime un utilisateur.",
        Description = "Supprime un utilisateur en fonction de son identifiant.")]
    public async Task<DeleteUserCommandResponse> DeleteUser(Guid id)
    {
        return await Mediator.Send(new DeleteUserCommand(id));
    }
}