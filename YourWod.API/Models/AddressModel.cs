using System;
using System.ComponentModel.DataAnnotations;

namespace YourWod.API.Models;

public class AddressModel
{

	public int Id { get; set; }
	public string Cep { get; set; }
	public string Rua { get; set; }
	public string Estado { get; set; }
	public int Numero { get; set; }

}

