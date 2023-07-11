using AutoMapper;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Profiles;

public class PrProfile : Profile
{
    public PrProfile(){
        CreateMap<CreatePrDto, PrModel>();
        CreateMap<UpdatePrDto, PrModel>();
        CreateMap<PrModel, ReadPrDto>().ForMember(pr => pr.Athlete, opt => opt.MapFrom(pr => pr.Athlete));

    }
}