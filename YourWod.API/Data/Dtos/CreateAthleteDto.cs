using System;
using static YourWod.API.Models.AthleteModel;
using System.ComponentModel.DataAnnotations;

namespace YourWod.API.Data.Dtos;

public class CreateAthleteDto
{
	public CreateAthleteDto()
	{
	}

    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? password { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public DateOnly? born_date { get; set; }
    public DateTime Date_account { get; set; }
    public ActiveStatus Active_yn { get; set; }
    public int BoxId { get; set; }
}

