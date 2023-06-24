using System;
using static YourWod.API.Models.AthleteModel;

namespace YourWod.API.Data.Dtos;

public class ReadAthleteDto
{


    public string? Email { get; set; }
    public ActiveStatus Active_yn { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public ReadAddressDto Address { get; set; }
    public ReadBoxDto Box { get; set; }
}

