using System;
namespace YourWod.API.Data.Dtos
{
	public class ReadWodAndAthleteDto
	{

		public int WodId { get; set; }
		public int AthleteId { get; set; }
        public TimeOnly Time_wod { get; set; }
        public int Score_Wod { get; set; }
        public DateTime Register_time { get; set; }
    }
}

