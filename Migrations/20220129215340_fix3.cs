using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactionTimeApp.Migrations
{
    public partial class fix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserDevice",
                table: "ReactionTests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserDevice",
                table: "ReactionTests");
        }
    }
}
