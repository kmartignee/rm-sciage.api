using rm_sciage.domain.DTOs.User;

namespace rm_sciage.application.Features.User.Queries.Get;

public class GetUserQueryResponse
{
    public UserResponseDto User { get; set; } = new();
}