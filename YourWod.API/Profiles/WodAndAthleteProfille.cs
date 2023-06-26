using System;
using AutoMapper;
using YourWod.API.Models;
using YourWod.API.Data;
using YourWod.API.Data.Dtos;

namespace YourWod.API.Profiles;

public class WodAndAthleteProfille : Profile
{
	public WodAndAthleteProfille()
	{
		CreateMap<WodAndAthleteModel, ReadWodAndAthleteDto>();
		CreateMap<CreateWodAndAthleteDto, WodAndAthleteModel>();
	}
}

