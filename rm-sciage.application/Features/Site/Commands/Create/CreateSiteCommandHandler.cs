using MediatR;

namespace rm_sciage.application.Features.Site.Commands.Create;

public class CreateSiteCommandHandler : IRequestHandler<CreateSiteCommand, CreateSiteCommandResponse>
{
    public Task<CreateSiteCommandResponse> Handle(CreateSiteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}