using AutoMapper;
using FluentValidation;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.Site.Validator;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.application.Features.Site.Commands.Update;

public class UpdateSiteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateSiteCommand, UpdateSiteCommandResponse>
{
    public async Task<UpdateSiteCommandResponse> Handle(UpdateSiteCommand request, CancellationToken cancellationToken)
    {
        var validator = new SiteDtoValidator();
        var validationResult = await validator.ValidateAsync(request.Site, cancellationToken);
        
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
        
        var site = mapper.Map<SiteEntity>(request.Site);
        site.Id = request.Id;
        site.LastModifiedDate = DateTime.Now;
        
        await unitOfWork.SiteRepository.UpdateAsync(site, cancellationToken);
        await unitOfWork.SaveAsync();
        
        return new UpdateSiteCommandResponse { Message = $"Site with {request.Id} updated successfully" };
    }
}