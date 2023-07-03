using System;
namespace YourWod.API.Data.Dtos;

public class CreateWodAndAthleteDto
{
    public int AthleteId { get; set; }
    public int WodId { get; set; }
    public TimeOnly Time_wod { get; set; }
    public int Score_Wod { get; set; }
    public DateTime Register_time { get; set; }
}

