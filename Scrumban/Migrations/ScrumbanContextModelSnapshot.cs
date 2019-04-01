﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scrumban.DataAccessLayer;

namespace Scrumban.Migrations
{
    [DbContext(typeof(ScrumbanContext))]
    partial class ScrumbanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomIdentityApp.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Password");

                    b.Property<int>("PictureID");

                    b.Property<int>("RoleID");

                    b.Property<string>("Surname");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Scrumban.Models.Defect", b =>
                {
                    b.Property<int>("DefectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Priority");

                    b.Property<string>("Severity");

                    b.Property<string>("State");

                    b.Property<string>("Status");

                    b.Property<int?>("StoryId");

                    b.HasKey("DefectId");

                    b.ToTable("Defects");
                });

            modelBuilder.Entity("Scrumban.Models.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Priorities");

                    b.HasData(
                        new { Id = 1, Name = "Low" },
                        new { Id = 2, Name = "Medium" },
                        new { Id = 3, Name = "Heigh" },
                        new { Id = 4, Name = "Immediate" }
                    );
                });

            modelBuilder.Entity("Scrumban.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new { Id = 1, Name = "Ready To Start" },
                        new { Id = 2, Name = "In Progress" },
                        new { Id = 3, Name = "Development Complete" },
                        new { Id = 4, Name = "Test Complete" },
                        new { Id = 5, Name = "Accepted" }
                    );
                });

            modelBuilder.Entity("Scrumban.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("PriorityId");

                    b.Property<int?>("ProgrammerId");

                    b.Property<int>("StoryStateId");

                    b.Property<int>("TaskId");

                    b.HasKey("Id");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StoryStateId");

                    b.ToTable("Stories");

                    b.HasData(
                        new { Id = 1, Description = "Description1", Name = "Story1", PriorityId = 2, StoryStateId = 1, TaskId = 0 },
                        new { Id = 2, Description = "Description2", Name = "Story2", PriorityId = 2, StoryStateId = 1, TaskId = 0 },
                        new { Id = 3, Description = "Description3", Name = "Story3", PriorityId = 2, StoryStateId = 1, TaskId = 0 }
                    );
                });

            modelBuilder.Entity("Scrumban.Models.StoryState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StoryStates");

                    b.HasData(
                        new { Id = 1, Name = "Non Started" },
                        new { Id = 2, Name = "In Progress" },
                        new { Id = 3, Name = "Rejected" },
                        new { Id = 4, Name = "In Complete" },
                        new { Id = 5, Name = "Done" },
                        new { Id = 6, Name = "Accepted" }
                    );
                });

            modelBuilder.Entity("Scrumban.Models.Story", b =>
                {
                    b.HasOne("Scrumban.Models.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Scrumban.Models.StoryState", "StoryState")
                        .WithMany()
                        .HasForeignKey("StoryStateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}