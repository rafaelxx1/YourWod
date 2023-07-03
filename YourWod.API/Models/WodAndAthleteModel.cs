using System;

namespace YourWod.API.Models;

public class WodAndAthleteModel
{
    public int AthleteId { get; set; }
    public virtual AthleteModel Athlete { get; set; }

    public int WodId { get; set; }
    public virtual WodModel Wod { get; set; }

    public TimeOnly Time_wod { get; set; }
    public int Score_Wod { get; set; }
    public DateTime Register_time { get; set; }
}

