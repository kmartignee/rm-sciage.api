using Ardalis.GuardClauses;
using MediatR;
using rm_sciage.application.Contracts.Persistance;

namespace rm_sciage.application.Features.User.Commands.Delete;

public class DeleteUserCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
{
    public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = await unitOfWork.UserRepository.GetByIdAsync(request.Id, cancellationToken);
        
        Guard.Against.Null(user);
        
        await unitOfWork.UserRepository.DeleteAsync(user, cancellationToken);
        await unitOfWork.SaveAsync();
        
        return new DeleteUserCommandResponse { Message = $"User with {user.Id} deleted successfully"};
    }
}