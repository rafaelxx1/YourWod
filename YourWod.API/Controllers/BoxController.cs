using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YourWod.API.Data;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Controllers;


[ApiController]
[Route("/controller")]
public class BoxController : ControllerBase
{
	private YourWodContext _context;
	private IMapper _mapper;

	public BoxController(YourWodContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	[HttpGet]
	public IEnumerable<ReadBoxDto> GetBox()
	{
		return _mapper.Map<List<ReadBoxDto>>(_context.Boxs);
	}

	[HttpGet("{id}")]
	public IActionResult GetBoxById(int id)
	{
		var box = _context.Boxs.FirstOrDefault(box => box.Id == id);
		if (box != null)
		{
			ReadBoxDto boxDto = _mapper.Map<ReadBoxDto>(box);
			return Ok(boxDto);
		}

		return NotFound();
	}

	[HttpPost]
	public IActionResult AddBox([FromBody] CreateBoxDto boxDto)
	{
		BoxModel box = _mapper.Map<BoxModel>(boxDto);
		_context.Boxs.Add(box);
		_context.SaveChanges();

		return CreatedAtAction(nameof(GetBoxById), new { id = box.Id }, boxDto);
	}

	[HttpPut("{id}")]
	public IActionResult UpdateBox(int id, [FromBody] UpdateBoxDto boxDto)
	{
		BoxModel? box = _context.Boxs.FirstOrDefault(box => box.Id == id);
		if(box == null) { return NotFound(); }

		_mapper.Map(boxDto, box);
		_context.SaveChanges();
		return NoContent();
	}


	[HttpDelete("{id}")]
	public IActionResult DeleteBox(int id)
	{
		BoxModel? box = _context.Boxs.FirstOrDefault(box => box.Id == id);
		if(box == null) { return NotFound(); }
		_context.Remove(box);
		_context.SaveChanges();
		return NoContent();
	}


}

