using System;
using System.ComponentModel.DataAnnotations;
namespace YourWod.API.Models;

public class WodModel
{

	[Key]
	[Required]
	public int Id { get; set; }
	public DateOnly Date_wod { get; set; }
	public string? Description { get; set; }
	public TimeOnly Time_wod { get; set; }
	public int Score_wod { get; set; }

	public int BoxId { get; set; }
	public virtual BoxModel? Box { get; set; }

	public virtual ICollection<WodAndAthleteModel>? WodAthletes { get; set; }
	//public int AddressId { get; set; }
	//public virtual AddressModel? Address { get; set; }


}

