using System;
using AutoMapper;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Profiles;

public class WodProfile : Profile
{
    public WodProfile()
    {
        CreateMap<UpdateWodDto, WodModel>();
        CreateMap<CreateWodDto, WodModel>();
        //CreateMap<WodModel, UpdateWodDto>();
        CreateMap<WodModel, ReadWodDto>();

    }
    
}

