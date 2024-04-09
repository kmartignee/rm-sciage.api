using MediatR;
using rm_sciage.domain.DTOs.Pointing;

namespace rm_sciage.application.Features.Pointing.Commands.Create;

public class CreatePointingCommand(PointingDto pointingDto) : IRequest<CreatePointingCommandResponse>
{
    public PointingDto Pointing { get; set; } = pointingDto;
}
