using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Medica.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    PrescriptionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DrFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    DrLastName = table.Column<string>(type: "TEXT", nullable: true),
                    PatientFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    PatientLastName = table.Column<string>(type: "TEXT", nullable: true),
                    DiseaseDiscription = table.Column<string>(type: "TEXT", nullable: true),
                    MedicinName = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PillsPerDay = table.Column<int>(type: "INTEGER", nullable: false),
                    Instructions = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.PrescriptionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescriptions");
        }
    }
}
