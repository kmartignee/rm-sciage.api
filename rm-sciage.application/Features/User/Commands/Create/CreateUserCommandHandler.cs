using MediatR;

namespace rm_sciage.application.Features.User.Commands.Create;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
{
    public Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}