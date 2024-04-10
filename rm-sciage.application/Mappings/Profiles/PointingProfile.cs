using AutoMapper;
using rm_sciage.domain.DTOs.Pointing;
using rm_sciage.domain.Entities.Pointing;

namespace rm_sciage.application.Mappings.Profiles;

public class PointingProfile : Profile
{
    public PointingProfile()
    {
        CreateMap<PointingEntity, PointingDto>();
        CreateMap<PointingEntity, PointingResponseDto>()
            .ForMember(dest => dest.SiteIds, opt => opt.MapFrom(src => src.Sites.Select(ps => ps.Id).ToList()))
            .ForMember(dest => dest.Clockings, opt => opt.MapFrom(src => src.Clockings.Select(pc => new ClockingDto
            {
                IsAm = pc.IsAm,
                ArrivalTime = pc.ArrivalTime.ToString(),
                DepartureTime = pc.DepartureTime.ToString()
            }).ToList()));
        CreateMap<PointingDto, PointingEntity>()
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.Now))
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
    }
}