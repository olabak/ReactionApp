using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactionTimeApp.Migrations
{
    public partial class fix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ReactionTime",
                table: "ReactionTests",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReactionTime",
                table: "ReactionTests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan));
        }
    }
}
