using AutoMapper;
using FluentValidation;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.application.Specification.Site;
using rm_sciage.domain.DTOs.Pointing.Validator;
using rm_sciage.domain.Entities.Pointing;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.application.Features.Pointing.Commands.Create;

public class CreatePointingCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<CreatePointingCommand, CreatePointingCommandResponse>
{
    public async Task<CreatePointingCommandResponse> Handle(CreatePointingCommand request,
        CancellationToken cancellationToken)
    {
        var validator = new PointingDtoValidator();
        var validationResult = await validator.ValidateAsync(request.Pointing, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var sites = await unitOfWork.SiteRepository.ListAsync(new SitesByIdsSpecification(request.Pointing.SiteIds),
            cancellationToken);
        var pointing = mapper.Map<PointingEntity>(request.Pointing);

        pointing.Sites = (ICollection<SiteEntity>)sites;
        pointing.Date = DateTime.Now.AddDays(-1);

        await unitOfWork.PointingRepository.AddAsync(pointing, cancellationToken);
        await unitOfWork.SaveAsync();

        return new CreatePointingCommandResponse { Message = $"Pointing with {pointing.Id} created successfully" };
    }
}