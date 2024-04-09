using MediatR;

namespace rm_sciage.application.Features.Pointing.Commands.Create;

public class CreatePointingCommandHandler : IRequestHandler<CreatePointingCommand, CreatePointingCommandResponse>
{
    public Task<CreatePointingCommandResponse> Handle(CreatePointingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}