using MediatR;
using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Commands.Create;

public class CreateSiteCommand(SiteDto siteDto) : IRequest<CreateSiteCommandResponse>
{
    public SiteDto Site { get; set; } = siteDto;
}