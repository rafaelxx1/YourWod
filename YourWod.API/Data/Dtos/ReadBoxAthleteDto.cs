using System;
using YourWod.API.Models;
using static YourWod.API.Models.AthleteModel;

namespace YourWod.API.Data.Dtos;

public class ReadBoxAthleteDto
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public ActiveStatus Active_yn { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
}

