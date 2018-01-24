using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ClassroomManager.Migrations
{
    public partial class Students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DOB = table.Column<string>(nullable: true),
                    adjustments = table.Column<bool>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    matricNumber = table.Column<string>(nullable: true),
                    origin = table.Column<string>(nullable: true),
                    yearOfStudy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
