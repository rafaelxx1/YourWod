﻿using System;
using AutoMapper;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Profiles;

public class AthleteProfile : Profile
{
	public AthleteProfile()
	{
		CreateMap<CreateAthleteDto, AthleteModel>();
		CreateMap<UpdateAthleteDto, AthleteModel>();
		//CreateMap<AthleteModel, UpdateAthleteDto>();
		CreateMap<AthleteModel, ReadAthleteDto>().ForMember(athleteDto => athleteDto.Box, opt => opt.MapFrom(athlete => athlete.Box));
		CreateMap<AthleteModel, ReadBoxAthleteDto>();
	}

}

