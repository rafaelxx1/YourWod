using System;
using static YourWod.API.Models.AthleteModel;
using System.ComponentModel.DataAnnotations;

namespace YourWod.API.Data.Dtos;

public class UpdateAthleteDto
{
	public UpdateAthleteDto()
	{
	}

    public string? email { get; set; }
    public string? password { get; set; }
    public DateTime date { get; set; }
    public ActiveStatus active_yn { get; set; }
}

