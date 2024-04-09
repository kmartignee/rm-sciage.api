using AutoMapper;
using rm_sciage.domain.DTOs.User;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.application.Mappings.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, UserEntity>().ReverseMap();
    }
}