using AutoMapper;
using rm_sciage.domain.DTOs.Pointing;
using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.application.Mappings.Profiles;

public class ClockingProfile : Profile
{
    public ClockingProfile()
    {
        CreateMap<ClockingDto, ClockingEntity>()
            .ForMember(dest => dest.ArrivalTime, 
                opt => opt.MapFrom(src => TimeSpan.Parse(src.ArrivalTime)))
            .ForMember(dest => dest.DepartureTime, 
            opt => opt.MapFrom(src => TimeSpan.Parse(src.DepartureTime)))
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
    }
}