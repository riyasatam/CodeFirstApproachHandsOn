using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_HandsOn.Migrations
{
    public partial class moviemodelcreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movieModels",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieCount = table.Column<int>(type: "int", nullable: false),
                    MovieType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieModels", x => x.MovieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movieModels");
        }
    }
}
