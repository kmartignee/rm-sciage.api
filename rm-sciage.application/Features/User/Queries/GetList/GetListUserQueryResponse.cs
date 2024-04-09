using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Queries.GetList;

public abstract class GetListUserQueryResponse
{
    public List<UserDto> Users { get; set; } = [];
}