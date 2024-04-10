using AutoMapper;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Queries.Get;

public class GetUserQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<GetUserQuery, GetUserQueryResponse>
{
    public async Task<GetUserQueryResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await unitOfWork.UserRepository.GetByIdAsync(request.Id, cancellationToken);

        return new GetUserQueryResponse { User = mapper.Map<UserResponseDto>(user) };
    }
}