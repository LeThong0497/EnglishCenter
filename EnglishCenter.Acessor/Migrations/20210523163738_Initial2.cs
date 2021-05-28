using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishCenter.Accessor.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ok",
                table: "DetailResults",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "DetailResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ok",
                table: "DetailResults");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "DetailResults");
        }
    }
}
