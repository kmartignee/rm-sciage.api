using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Queries.Get;

public abstract class GetUserQueryResponse
{
    public UserDto User { get; set; } = new();
}