using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Data.Migrations
{
    /// <inheritdoc />
    public partial class EvPArtPArt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestModels");

            migrationBuilder.CreateTable(
                name: "Evenimente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    denumire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenimente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participanti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participanti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participari",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdParticipant = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEveniment = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EvenimentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ParticipantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participari_Evenimente_EvenimentId",
                        column: x => x.EvenimentId,
                        principalTable: "Evenimente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Participari_Participanti_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participanti",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participari_EvenimentId",
                table: "Participari",
                column: "EvenimentId");

            migrationBuilder.CreateIndex(
                name: "IX_Participari_ParticipantId",
                table: "Participari",
                column: "ParticipantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participari");

            migrationBuilder.DropTable(
                name: "Evenimente");

            migrationBuilder.DropTable(
                name: "Participanti");

            migrationBuilder.CreateTable(
                name: "TestModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestModels", x => x.Id);
                });
        }
    }
}
