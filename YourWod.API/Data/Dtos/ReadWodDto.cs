﻿using System;
namespace YourWod.API.Data.Dtos
{
	public class ReadWodDto
	{
        public DateOnly Date_wod { get; set; }
        public string? Description { get; set; }
        public TimeOnly Time_wod { get; set; }
        public int Score_wod { get; set; }
        public ReadBoxDto Box { get; set; }
        //public ReadAddressDto? addressDto { get; set; }
    }
}

