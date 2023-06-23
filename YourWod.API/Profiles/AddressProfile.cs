using System;
using System;
using AutoMapper;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Profiles;

public class AddressProfile : Profile
{
	public AddressProfile()
	{
		CreateMap<AddressModel, ReadAddressDto>();
		CreateMap<CreateAddressDto, AddressModel>();
		CreateMap<UpdateAddressDto, AddressModel>();

	}
}

