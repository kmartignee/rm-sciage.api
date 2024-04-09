using MediatR;

namespace rm_sciage.application.Features.User.Commands.Delete;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
{
    public Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}