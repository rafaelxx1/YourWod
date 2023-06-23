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
	public string? Email { get; set; }
	public string? password { get; set; }
	public DateTime Date { get; set; }
	public ActiveStatus Active_yn { get; set; }

	public int AddressId { get; set; }
	public virtual AddressModel Address { get; set; }
}

