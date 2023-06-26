using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YourWod.API.Data.Dtos;
using YourWod.API.Data;
using YourWod.API.Models;

namespace YourWod.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WodAndAthleteController : ControllerBase
{
	private YourWodContext _context;
	private IMapper _mapper;

	public WodAndAthleteController(YourWodContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

    [HttpPost]
    public IActionResult AddWodAndAthlete(CreateWodAndAthleteDto wodAthleteDto)
    {
        WodAndAthleteModel wodAthlete = _mapper.Map<WodAndAthleteModel>(wodAthleteDto);
        _context.WodAthletes.Add(wodAthlete);
        _context.SaveChanges();
		return CreatedAtAction(nameof(GetWodAndAthleteById), new { AthleteId = wodAthlete.AthleteId, WodId = wodAthlete.WodId }, wodAthlete);

    }

    [HttpGet]
	public IEnumerable<ReadWodAndAthleteDto> GetWodAndAthlete()
	{
		return _mapper.Map<List<ReadWodAndAthleteDto>>(_context.WodAthletes);
	}

	[HttpGet("Athlete={athleteId}/Wod={wodId}")]
	public IActionResult GetWodAndAthleteById(int athleteId, int wodId)
	{
		WodAndAthleteModel? WodAthlete = _context.WodAthletes.FirstOrDefault(wodAthlete => wodAthlete.AthleteId == athleteId && wodAthlete.WodId == wodId);
		if(WodAthlete != null)
		{
			ReadWodAndAthleteDto wodAthleteDto = _mapper.Map<ReadWodAndAthleteDto>(WodAthlete);
			return Ok(wodAthleteDto);
		}
		return NotFound();
	}

}

