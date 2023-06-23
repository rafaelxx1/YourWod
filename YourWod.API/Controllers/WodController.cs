using AutoMapper;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;
using YourWod.API.Profiles;
using Microsoft.AspNetCore.Mvc;
using System;
using YourWod.API.Data;

namespace YourWod.API.Controllers;

[ApiController]
[Route("[controller]")]

public class WodController : ControllerBase
{
	private YourWodContext _context;
	private IMapper _mapper;

	public WodController(YourWodContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	[HttpPost]
	public IActionResult AddWod([FromBody] CreateWodDto wodDto)
	{
		WodModel wod = _mapper.Map<WodModel>(wodDto);
		_context.Wods.Add(wod);
		_context.SaveChanges();

		return CreatedAtAction(nameof(GetWodById), new { id = wod.Id }, wodDto);
	}

	[HttpGet]
	public IEnumerable<ReadWodDto> GetWod()
	{
		return _mapper.Map<List<ReadWodDto>>(_context.Wods.ToList());
	}

	[HttpGet("{id}")]
	public IActionResult GetWodById(int id)
	{
		WodModel? wod = _context.Wods.FirstOrDefault(wod => wod.Id == id);
		if(wod != null) { ReadWodDto wodDto = _mapper.Map<ReadWodDto>(wod); return Ok(wodDto); }
		return NotFound();

	}

	[HttpPut("{id}")]
	public IActionResult UpdateWod(int id, [FromBody] UpdateWodDto wodDto)
	{
		WodModel? wod = _context.Wods.FirstOrDefault(wod => wod.Id == id);
		if(wod == null) { return NotFound(); }
		_mapper.Map(wodDto, wod);
		_context.SaveChanges();
		return NoContent();
	}

	[HttpDelete("{id}")]
	public IActionResult DeleteWod(int id)
	{
		WodModel? wod = _context.Wods.FirstOrDefault(wod => wod.Id == id);
		if(wod == null) { return NotFound(); }
		_context.Remove(wod);
		_context.SaveChanges();
		return NoContent();
	}




}

