using Microsoft.EntityFrameworkCore.Migrations;

namespace GymModel.Migrations
{
    public partial class JunctionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrainingPlan",
                table: "TrainingProgram");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrainingPlan",
                table: "TrainingProgram",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
