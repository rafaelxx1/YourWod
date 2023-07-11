using System;
using System.ComponentModel.DataAnnotations;

namespace YourWod.API.Models;

public class AthleteModel
{
	public enum ActiveStatus
	{
		Active,
		Inactive,
		Pending
	}


	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Email { get; set; }
	public string? password { get; set; }
	public string? Cidade { get; set; }
	public string? Estado { get; set; }
	public DateOnly? born_date { get; set; }
	public DateTime? Date_account { get; set; }
	public ActiveStatus Active_yn { get; set; }

	public int BoxId { get; set; }
	public virtual BoxModel? Box { get; set; }

	public virtual ICollection<WodAndAthleteModel>? WodAthletes { get; set; }

	public virtual ICollection<PrModel>? Prs {get; set;}


}

