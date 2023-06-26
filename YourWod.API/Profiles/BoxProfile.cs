using System;
using AutoMapper;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Profiles
{
	public class BoxProfile : Profile
	{
		public BoxProfile()
		{
			CreateMap<CreateBoxDto, BoxModel>();
			CreateMap<UpdateBoxDto, BoxModel>();
			CreateMap<BoxModel, ReadBoxDto>().ForMember(boxDto => boxDto.Athletes, opt => opt.MapFrom(box => box.Athlete))
				.ForMember(BoxDto => BoxDto.Wods, opt => opt.MapFrom(box => box.Wod));
			CreateMap<BoxModel, ReadAthleteBoxDto>();

			//.ForMember(boxDto => boxDto.Athletes, opt => opt.MapFrom(box => box.Athlete));
		}
	}
}

