using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Queries.GetList;

public class GetListUserQueryResponse
{
    public List<UserResponseDto> Users { get; set; } = [];
}