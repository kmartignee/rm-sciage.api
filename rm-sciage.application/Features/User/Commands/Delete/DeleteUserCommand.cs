using MediatR;

namespace rm_sciage.application.Features.User.Commands.Delete;

public class DeleteUserCommand(Guid id) : IRequest<DeleteUserCommandResponse>
{
    public Guid Id { get; } = id;
}