﻿using AutoMapper;
using rm_sciage.domain.DTOs.Site;
using rm_sciage.domain.Entities.Site;

namespace rm_sciage.application.Mappings.Profiles;

public class SiteProfile : Profile
{
    public SiteProfile()
    {
        CreateMap<SiteEntity, SiteDto>();
        CreateMap<SiteEntity, SiteResponseDto>();
        CreateMap<SiteDto, SiteEntity>()
            .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
    }
}