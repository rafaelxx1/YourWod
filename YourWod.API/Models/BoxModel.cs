using System;
using System.ComponentModel.DataAnnotations;
using YourWod.API.Models;

namespace YourWod.API.Models
{
	public class BoxModel
	{


		[Key]
		[Required]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Cep { get; set; }
		public string? Cidade { get; set; }
		public string? Estado { get; set; }
		public DateTime Data_cadastro { get; set; }

		public virtual ICollection<WodModel>? Wod { get; set; }
		public virtual ICollection<AthleteModel>? Athlete { get; set; }


	}
}

