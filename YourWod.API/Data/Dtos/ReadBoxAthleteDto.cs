using System;
using YourWod.API.Models;
using static YourWod.API.Models.AthleteModel;

namespace YourWod.API.Data.Dtos;

public class ReadBoxAthleteDto
{
    // Classe utilizada para leitura do Athlete pelo Controller BOX.
    public string? Name { get; set; }
    public string? Email { get; set; }
    public ActiveStatus Active_yn { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
}

