using AutoMapper;
using FluentValidation;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.User.Validator;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.application.Features.User.Commands.Create;

public class CreateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
{
    public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new UserDtoValidator();
        var validationResult = await validator.ValidateAsync(request.User, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
        
        var user = await unitOfWork.UserRepository.AddAsync(mapper.Map<UserEntity>(request.User), cancellationToken);
        user.CreatedDate = DateTime.Now;

        await unitOfWork.SaveAsync();
        
        return new CreateUserCommandResponse { Message = $"User with {user.Id} created successfully" };
    }
}