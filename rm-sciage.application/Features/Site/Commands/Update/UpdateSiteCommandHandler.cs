using MediatR;

namespace rm_sciage.application.Features.Site.Commands.Update;

public class UpdateSiteCommandHandler : IRequestHandler<UpdateSiteCommand, UpdateSiteCommandResponse>
{
    public Task<UpdateSiteCommandResponse> Handle(UpdateSiteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}