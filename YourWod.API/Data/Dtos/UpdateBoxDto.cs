﻿using System;
namespace YourWod.API.Data.Dtos
{
	public class UpdateBoxDto
	{

        public string Name { get; set; }
        public string Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public DateTime Data { get; set; }
    }
}

