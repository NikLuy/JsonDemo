using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JsonDemoApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chargers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_Subjekt = table.Column<int>(type: "int", nullable: true),
                    Id_Zustelladresse = table.Column<int>(type: "int", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subjekt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zustell_Subjekt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chargers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chargers");
        }
    }
}
