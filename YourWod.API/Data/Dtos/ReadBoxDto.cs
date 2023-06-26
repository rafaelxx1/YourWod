using System;
namespace YourWod.API.Data.Dtos
{
	public class ReadBoxDto
	{
        public string Name { get; set; }
        public string Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public DateTime Data_cadastro { get; set; }

        public ICollection<ReadWodBoxDto>? Wods { get; set; }
        public ICollection<ReadBoxAthleteDto>? Athletes { get; set; }
    }
}

