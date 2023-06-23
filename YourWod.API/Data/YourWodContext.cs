using System;
using Microsoft.EntityFrameworkCore;
using YourWod.API.Models;

namespace YourWod.API.Data;

public class YourWodContext : DbContext
{
	public YourWodContext(DbContextOptions<YourWodContext> opts) : base(opts)
	{

	}

	public DbSet<AthleteModel> Athletes { get; set; }
	public DbSet<WodModel> Wods { get; set; }
	public DbSet<AddressModel> Address { get; set; }
	public DbSet<BoxModel> Boxs { get; set; }
}

