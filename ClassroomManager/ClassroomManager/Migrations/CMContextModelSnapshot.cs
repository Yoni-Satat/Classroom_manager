﻿// <auto-generated />
using ClassroomManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ClassroomManager.Migrations
{
    [DbContext(typeof(CMContext))]
    partial class CMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("ClassroomManager.Models.Absence", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Reason");

                    b.HasKey("ID");

                    b.ToTable("Absences");
                });

            modelBuilder.Entity("ClassroomManager.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("courseUniId");

                    b.Property<string>("level");

                    b.Property<int>("numberOfLessons");

                    b.Property<string>("title");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ClassroomManager.Models.Lesson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<DateTime>("endTime");

                    b.Property<int>("index");

                    b.Property<bool>("isMandatory");

                    b.Property<string>("location");

                    b.Property<DateTime>("startTime");

                    b.Property<string>("topic");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ClassroomManager.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<bool>("adjustments");

                    b.Property<string>("firstName");

                    b.Property<string>("gender");

                    b.Property<string>("lastName");

                    b.Property<string>("matricNumber");

                    b.Property<string>("origin");

                    b.Property<int>("yearOfStudy");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ClassroomManager.Models.Lesson", b =>
                {
                    b.HasOne("ClassroomManager.Models.Course", "course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
