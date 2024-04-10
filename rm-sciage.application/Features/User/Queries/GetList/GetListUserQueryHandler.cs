using AutoMapper;
using MediatR;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Queries.GetList;

public class GetListUserQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)  : IRequestHandler<GetListUserQuery, GetListUserQueryResponse>
{
    public async Task<GetListUserQueryResponse> Handle(GetListUserQuery request, CancellationToken cancellationToken)
    {
        var users = await unitOfWork.UserRepository.ListAllAsync(cancellationToken);

        return new GetListUserQueryResponse { Users = mapper.Map<List<UserResponseDto>>(users) };
    }
}