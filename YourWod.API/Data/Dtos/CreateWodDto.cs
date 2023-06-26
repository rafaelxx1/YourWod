using System;
namespace YourWod.API.Data.Dtos
{
	public class CreateWodDto
	{
        public DateOnly Date_wod { get; set; }
        public string? Description { get; set; }
        public TimeOnly Time_wod { get; set; }
        public int Score_wod { get; set; }
        public int BoxId { get; set; }
        //public int AddressId { get; set; }
    }
}

