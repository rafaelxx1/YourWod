using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourWod.API.Migrations
{
    /// <inheritdoc />
    public partial class wodathleteNewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Register_time",
                table: "WodAthletes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Score_Wod",
                table: "WodAthletes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time_wod",
                table: "WodAthletes",
                type: "time(6)",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Register_time",
                table: "WodAthletes");

            migrationBuilder.DropColumn(
                name: "Score_Wod",
                table: "WodAthletes");

            migrationBuilder.DropColumn(
                name: "Time_wod",
                table: "WodAthletes");
        }
    }
}
