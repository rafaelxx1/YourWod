using System;
using static YourWod.API.Models.AthleteModel;

namespace YourWod.API.Data.Dtos;

public class ReadAthleteDto
{


    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public DateOnly? born_date { get; set; }
    public ActiveStatus Active_yn { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public ReadAthleteBoxDto Box { get; set; }
}

