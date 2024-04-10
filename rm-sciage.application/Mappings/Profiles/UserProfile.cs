using AutoMapper;
using rm_sciage.domain.DTOs.User;
using rm_sciage.domain.Entities.User;

namespace rm_sciage.application.Mappings.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserEntity, UserDto>();
        CreateMap<UserEntity, UserResponseDto>();
        CreateMap<UserDto, UserEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
    }
}