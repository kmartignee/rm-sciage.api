using MediatR;
using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Commands.Update;

public class UpdateUserCommand(Guid guid, UserDto userDto) : IRequest<UpdateUserCommandResponse>
{
    public Guid Id { get; set; } = guid;
    public UserDto User { get; set; } = userDto;
}