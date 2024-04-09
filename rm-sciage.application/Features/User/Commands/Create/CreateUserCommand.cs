using MediatR;
using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Commands.Create;

public class CreateUserCommand(UserDto userDto) : IRequest<CreateUserCommandResponse>
{
    public UserDto User { get; set; } = userDto;
}