using AutoMapper;
using rm_sciage.domain.DTOs.Site;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.application.Mappings.Profiles;

public class SiteProfile : Profile
{
    public SiteProfile()
    {
        CreateMap<SiteDto, SiteEntity>().ReverseMap();
    }
}