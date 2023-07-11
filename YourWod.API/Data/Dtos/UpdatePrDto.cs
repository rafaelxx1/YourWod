using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourWod.API.Data.Dtos;

public class UpdatePrDto
{
    public string? Category { get; set; }
    public DateOnly Date_pr { get; set; }
    public int Weight { get; set; }
 
}