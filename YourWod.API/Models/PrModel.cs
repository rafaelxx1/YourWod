using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourWod.API.Models;

public class PrModel
{
    public int Id {get; set;}
    public string? Category { get; set; }
    public DateOnly Date_pr { get; set; }
    public int Weight { get; set; }
    public int AthleteId { get; set; }
    public virtual AthleteModel? Athlete {get; set;}   
}