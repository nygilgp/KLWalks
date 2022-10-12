using System;
using AutoMapper;

namespace KLWalks.API.Profiles
{
    public class RegionsProfile: Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
                //.ForMember(dest => dest.Id, options => options.MapFrom(src => src.RegionId));
        }
    }
}

