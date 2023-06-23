using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YourWod.API.Data;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Controllers;


[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
	private YourWodContext _context;
	private IMapper _mapper;

	public AddressController(YourWodContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	[HttpPost]
	public IActionResult AddAddress([FromBody] CreateAddressDto addressDto)
	{
		AddressModel address = _mapper.Map<AddressModel>(addressDto);
		_context.Address.Add(address);
		_context.SaveChanges();
		return CreatedAtAction(nameof(GetAddressById), new { id = address.Id }, address);
	}

	[HttpGet]
	public IEnumerable<ReadAddressDto> GetAddress()
	{
		return _mapper.Map<List<ReadAddressDto>>(_context.Address);
	}

	[HttpGet("{id}")]
	public IActionResult GetAddressById(int id)
	{
		AddressModel? address = _context.Address.FirstOrDefault(ad => ad.Id == id);
		if(address != null)
		{
			ReadAddressDto addressDto = _mapper.Map<ReadAddressDto>(address);
			return Ok(addressDto);
		}
		return NotFound();
		

	}

	[HttpPut("{id}")]
	public IActionResult UpdateAddress(int id, UpdateAddressDto addressDto)
	{
		AddressModel? address = _context.Address.FirstOrDefault(ad => ad.Id == id);
		if(address == null) { return NotFound(); }
		_mapper.Map(addressDto, address);
		_context.SaveChanges();
		return NoContent();
	}

	[HttpDelete("{id}")]
	public IActionResult DeleteAddress(int id)
	{
		AddressModel? address = _context.Address.FirstOrDefault(ad => ad.Id == id);
		if(address == null) { return NotFound(); }
		_context.Remove(address);
		_context.SaveChanges();
		return NoContent();
	}
}

