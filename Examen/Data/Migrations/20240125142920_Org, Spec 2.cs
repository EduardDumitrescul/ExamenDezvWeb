using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrgSpec2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizatori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizatori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizatori_Participanti_Id",
                        column: x => x.Id,
                        principalTable: "Participanti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spectatori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spectatori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spectatori_Participanti_Id",
                        column: x => x.Id,
                        principalTable: "Participanti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizatori");

            migrationBuilder.DropTable(
                name: "Spectatori");
        }
    }
}
