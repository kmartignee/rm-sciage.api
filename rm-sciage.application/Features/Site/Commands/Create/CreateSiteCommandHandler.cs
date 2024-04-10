using AutoMapper;
using FluentValidation;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.Site.Validator;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.application.Features.Site.Commands.Create;

public class CreateSiteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateSiteCommand, CreateSiteCommandResponse>
{
    public async Task<CreateSiteCommandResponse> Handle(CreateSiteCommand request, CancellationToken cancellationToken)
    {
        var validator = new SiteDtoValidator();
        var validationResult = await validator.ValidateAsync(request.Site, cancellationToken);
        
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
        
        var site = await unitOfWork.SiteRepository.AddAsync(mapper.Map<SiteEntity>(request.Site), cancellationToken);
        await unitOfWork.SaveAsync();
        
        return new CreateSiteCommandResponse { Message = $"Site with {site.Id} created successfully" };
    }
}