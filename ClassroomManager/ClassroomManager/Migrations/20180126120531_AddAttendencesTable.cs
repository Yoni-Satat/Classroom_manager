using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ClassroomManager.Migrations
{
    public partial class AddAttendencesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    courseID = table.Column<int>(nullable: false),
                    lessonID = table.Column<int>(nullable: false),
                    present = table.Column<bool>(nullable: false),
                    reasonID = table.Column<int>(nullable: false),
                    studentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Attendances_Courses_courseID",
                        column: x => x.courseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Lessons_lessonID",
                        column: x => x.lessonID,
                        principalTable: "Lessons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Absences_reasonID",
                        column: x => x.reasonID,
                        principalTable: "Absences",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_studentID",
                        column: x => x.studentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_courseID",
                table: "Attendances",
                column: "courseID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_lessonID",
                table: "Attendances",
                column: "lessonID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_reasonID",
                table: "Attendances",
                column: "reasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_studentID",
                table: "Attendances",
                column: "studentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");
        }
    }
}
