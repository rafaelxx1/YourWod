using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using YourWod.API.Data;
using YourWod.API.Data.Dtos;
using YourWod.API.Models;

namespace YourWod.API.Controllers;

[ApiController]
[Route("[controller]")]

public class PrController : ControllerBase
{
    private YourWodContext _context;
    private IMapper _mapper;

    public PrController(YourWodContext context, IMapper mapper){
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public IEnumerable<ReadPrDto> GetPr(){
        return _mapper.Map<List<ReadPrDto>>(_context.Prs.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetPrById(int id){
        
        var pr = _context.Prs.FirstOrDefault(pr => pr.Id == id);
        if(pr == null)
        {
            return NotFound();
        }else
        {
            var prDto = _mapper.Map<ReadPrDto>(pr);
            return Ok(prDto);
        }
    }

    [HttpPost]
    public IActionResult AddPr([FromBody] CreatePrDto prDto){
        PrModel prModel = _mapper.Map<PrModel>(prDto);
        _context.Prs.Add(prModel);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetPrById), new { id = prModel.Id}, prModel);
    }

    [HttpPut("{id}")]
    public IActionResult ChangePr(int id, [FromBody] UpdatePrDto prDto){
        var pr = _context.Prs.FirstOrDefault(pr => pr.Id == id);
        if(pr == null) { return NotFound(); }
        _mapper.Map(prDto, pr);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePr(int id){
        var pr = _context.Prs.FirstOrDefault(pr => pr.Id == id);
        if(pr == null) {return NotFound();}
        _context.Remove(pr);
        _context.SaveChanges();
        return NoContent();
    }
}