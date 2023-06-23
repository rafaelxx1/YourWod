using System;
using System.ComponentModel.DataAnnotations;

namespace YourWod.API.Models
{
	public class BoxModel
	{
		public BoxModel()
		{
		}

		[Key]
		[Required]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Cep { get; set; }
		public DateTime Data { get; set; } 
	}
}

