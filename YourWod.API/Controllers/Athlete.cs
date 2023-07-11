using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using YourWod.API.Data;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Controllers;

[ApiController]
[Route("[controller]")]
public class Athlete : ControllerBase
{
	private YourWodContext _context;
	private IMapper _mapper;

	public Athlete(YourWodContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	/*[HttpPost]
	public IActionResult AddAthlete([FromBody] AthleteModel athlete)
	{
		_context.Athletes.Add(athlete);
		return CreatedAtAction(nameof)
	}*/

	[HttpGet]
	public IEnumerable<ReadAthleteDto> GetAthlete()
	{

        //var athletes = _context.Athletes.Include(a => a.Address).ToList();
        //var athletesDto = _mapper.Map<List<ReadAthleteDto>>(athletes);
        //return athletesDto;

        return _mapper.Map<List<ReadAthleteDto>>(_context.Athletes.ToList());
	}

	[HttpGet("{id}")]
	public IActionResult getAthleteById(int id)
	{
		var athlete = _context.Athletes.FirstOrDefault(athlete => athlete.Id == id);
		if (athlete == null)
		{
			return NotFound();
		}
		else
		{
			var athleteDto = _mapper.Map<ReadAthleteDto>(athlete);
			return Ok(athleteDto);
		}
	}

	[HttpPost]
	public IActionResult AddAthlete([FromBody] CreateAthleteDto athleteDto)
	{
		AthleteModel athlete = _mapper.Map<AthleteModel>(athleteDto);


		_context.Athletes.Add(athlete);
		_context.SaveChanges();

		return CreatedAtAction(nameof(getAthleteById), new { id = athlete.Id }, athlete);
	}


	[HttpPut("{id}")]
	public IActionResult changeAthlete(int id, [FromBody] UpdateAthleteDto athleteDto)
	{
		var athlete = _context.Athletes.FirstOrDefault(athlete => athlete.Id == id);
		if(athlete == null)
		{
			return NotFound();
		}
		else
		{
			_mapper.Map(athleteDto, athlete);
			_context.SaveChanges();
			return NoContent();	
			
		}

	}

	[HttpPatch("{id}")]
	public IActionResult updateAthletePatch(int id, JsonPatchDocument<UpdateAthleteDto> patch)
	{
		var athlete = _context.Athletes.FirstOrDefault(athlete => athlete.Id == id);
		if(athlete == null)
		{
			return NotFound();
		}
			var updateAthlete = _mapper.Map<UpdateAthleteDto>(athlete);
			patch.ApplyTo(updateAthlete, ModelState);

			if (!TryValidateModel(updateAthlete))
			{
				return ValidationProblem(ModelState);
			}
				_mapper.Map(updateAthlete, athlete);
				_context.SaveChanges();
				return NoContent();

	}

	[HttpDelete("{id}")]
	public IActionResult DeleteAthlete(int id)
	{
		var athlete = _context.Athletes.FirstOrDefault(athlete => athlete.Id == id);
		if(athlete == null) { return NotFound(); }

		_context.Remove(athlete);
		_context.SaveChanges();
		return NoContent();
		
	}

}

