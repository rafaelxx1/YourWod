using System;
namespace YourWod.API.Data.Dtos
{
	public class ReadWodBoxDto
	{
        //Classe utilizada para leitura dos Wods pelo Controller BOX
        public DateOnly Date_wod { get; set; }
        public string? Description { get; set; }
        public TimeOnly Time_wod { get; set; }
        public int Score_wod { get; set; }
    }
}

