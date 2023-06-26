using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using YourWod.API.Controllers;
using YourWod.API.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YourWod.API.Data;

public class YourWodContext : DbContext
{
	public YourWodContext(DbContextOptions<YourWodContext> opts) : base(opts)
	{

	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<WodAndAthleteModel>().HasKey(WodAthlete => new { WodAthlete.AthleteId, WodAthlete.WodId });

		builder.Entity<WodAndAthleteModel>().HasOne(WodAthlete => WodAthlete.Athlete).WithMany(athlete => athlete.WodAthletes)
			.HasForeignKey(WodAthlete => WodAthlete.AthleteId);

		builder.Entity<WodAndAthleteModel>().HasOne(WodAthlete => WodAthlete.Wod).WithMany(wod => wod.WodAthletes)
			.HasForeignKey(WodAthlete => WodAthlete.WodId);
	}

	public DbSet<AthleteModel> Athletes { get; set; }
    public DbSet<WodModel> Wods { get; set; }
    public DbSet<AddressModel> Address { get; set; }
    public DbSet<BoxModel> Boxs { get; set; }
	public DbSet<WodAndAthleteModel> WodAthletes { get; set; }
}

