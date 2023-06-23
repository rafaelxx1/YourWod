using System;
namespace YourWod.API.Data.Dtos
{
	public class ReadWodDto
	{
        public int Id { get; set; }
        public DateTime Date_wod { get; set; }
        public string? Description { get; set; }
        public DateTime Time_wod { get; set; }
        public int Score_wod { get; set; }
        //public ReadAddressDto? addressDto { get; set; }
    }
}

