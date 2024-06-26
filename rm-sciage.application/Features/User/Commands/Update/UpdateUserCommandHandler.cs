﻿using AutoMapper;
using FluentValidation;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.User.Validator;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.application.Features.User.Commands.Update;

public class UpdateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>
{
    public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new UserDtoValidator();
        var validationResult = await validator.ValidateAsync(request.User, cancellationToken);
        
        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var user = mapper.Map<UserEntity>(request.User);
        user.Id = request.Id;
        user.LastModifiedDate = DateTime.Now;
        
        await unitOfWork.UserRepository.UpdateAsync(user, cancellationToken);
        await unitOfWork.SaveAsync();
        
        return new UpdateUserCommandResponse { Message = $"User with {request.Id} updated successfully" };
    }
}