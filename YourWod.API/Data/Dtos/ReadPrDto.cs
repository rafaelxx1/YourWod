using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourWod.API.Data.Dtos
{
    public class ReadPrDto
    {
    public string? Category { get; set; }
    public DateOnly Date_pr { get; set; }
    public int Weight { get; set; }
    public ReadAthleteDto? Athlete {get; set;}
    }
}