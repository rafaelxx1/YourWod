using System;
namespace YourWod.API.Data.Dtos
{
	public class ReadBoxDto
	{
        public string Name { get; set; }
        public string Cep { get; set; }
        public DateTime Data { get; set; }
        public ICollection<ReadBoxAthleteDto>? Athletes { get; set; }
    }
}

