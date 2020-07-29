using Microsoft.EntityFrameworkCore.Migrations;

namespace GymModel.Migrations
{
    public partial class AddingDailyPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DailyPlan",
                table: "TrainingProgram",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyPlan",
                table: "TrainingProgram");
        }
    }
}
