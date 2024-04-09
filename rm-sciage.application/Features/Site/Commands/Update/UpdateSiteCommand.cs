using MediatR;
using rm_sciage.domain.DTOs.Site;

namespace rm_sciage.application.Features.Site.Commands.Update;

public class UpdateSiteCommand(Guid guid, SiteDto siteDto) : IRequest<UpdateSiteCommandResponse>
{
    public Guid Id { get; set; } = guid;
    public SiteDto Site { get; set; } = siteDto;
}