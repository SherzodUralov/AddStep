﻿// <auto-generated />
using System;
using AddStep.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddStep.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddStep.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("GroupId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("AddStep.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("AddStep.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("AddStep.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("TyutorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TyutorId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("AddStep.Models.Ilmiy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InteristId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InteristId");

                    b.ToTable("Ilmiys");
                });

            modelBuilder.Entity("AddStep.Models.Interist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Interists");
                });

            modelBuilder.Entity("AddStep.Models.Musiqa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InteristId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InteristId");

                    b.ToTable("Musiqas");
                });

            modelBuilder.Entity("AddStep.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("AddStep.Models.Sport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InteristId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InteristId");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("AddStep.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("Contract")
                        .HasColumnType("int");

                    b.Property<int>("Cours")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("IlmiyId")
                        .HasColumnType("int");

                    b.Property<int>("InteristId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("LiveReady")
                        .HasColumnType("int");

                    b.Property<string>("MobileNamber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("MusiqaId")
                        .HasColumnType("int");

                    b.Property<int?>("Nation")
                        .HasColumnType("int");

                    b.Property<int?>("Nogiron")
                        .HasColumnType("int");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhotoFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.Property<string>("SureName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StudentId");

                    b.HasIndex("BranchId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("FacultyId");

                    b.HasIndex("GroupId");

                    b.HasIndex("IlmiyId");

                    b.HasIndex("InteristId");

                    b.HasIndex("MusiqaId");

                    b.HasIndex("RegionId");

                    b.HasIndex("SportId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AddStep.Models.Tyutor", b =>
                {
                    b.Property<int>("TyutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MobileNamber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhotoFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<string>("Resime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Staj")
                        .HasColumnType("int");

                    b.Property<string>("SureName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("TyutorId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("RegionId");

                    b.ToTable("Tyutors");
                });

            modelBuilder.Entity("AddStep.Models.Branch", b =>
                {
                    b.HasOne("AddStep.Models.Faculty", "Faculty")
                        .WithMany("Branches")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Group", null)
                        .WithMany("Branches")
                        .HasForeignKey("GroupId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("AddStep.Models.District", b =>
                {
                    b.HasOne("AddStep.Models.Region", "Region")
                        .WithMany("Districts")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("AddStep.Models.Group", b =>
                {
                    b.HasOne("AddStep.Models.Tyutor", "Tyutor")
                        .WithMany("Groups")
                        .HasForeignKey("TyutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tyutor");
                });

            modelBuilder.Entity("AddStep.Models.Ilmiy", b =>
                {
                    b.HasOne("AddStep.Models.Interist", "Interist")
                        .WithMany("Ilmiys")
                        .HasForeignKey("InteristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interist");
                });

            modelBuilder.Entity("AddStep.Models.Musiqa", b =>
                {
                    b.HasOne("AddStep.Models.Interist", "Interist")
                        .WithMany("Musiqas")
                        .HasForeignKey("InteristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interist");
                });

            modelBuilder.Entity("AddStep.Models.Sport", b =>
                {
                    b.HasOne("AddStep.Models.Interist", "Interist")
                        .WithMany("Sports")
                        .HasForeignKey("InteristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interist");
                });

            modelBuilder.Entity("AddStep.Models.Student", b =>
                {
                    b.HasOne("AddStep.Models.Branch", "Branch")
                        .WithMany("Students")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.District", "District")
                        .WithMany("Students")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Faculty", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Ilmiy", "Ilmiy")
                        .WithMany("Students")
                        .HasForeignKey("IlmiyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Interist", "Interist")
                        .WithMany("Students")
                        .HasForeignKey("InteristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Musiqa", "Musiqa")
                        .WithMany("Students")
                        .HasForeignKey("MusiqaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Region", "Region")
                        .WithMany("Students")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Sport", "Sport")
                        .WithMany("Students")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("District");

                    b.Navigation("Faculty");

                    b.Navigation("Group");

                    b.Navigation("Ilmiy");

                    b.Navigation("Interist");

                    b.Navigation("Musiqa");

                    b.Navigation("Region");

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("AddStep.Models.Tyutor", b =>
                {
                    b.HasOne("AddStep.Models.District", "District")
                        .WithMany("Tyutors")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AddStep.Models.Region", "Region")
                        .WithMany("Tyutors")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("AddStep.Models.Branch", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.District", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Tyutors");
                });

            modelBuilder.Entity("AddStep.Models.Faculty", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.Group", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.Ilmiy", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.Interist", b =>
                {
                    b.Navigation("Ilmiys");

                    b.Navigation("Musiqas");

                    b.Navigation("Sports");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.Musiqa", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.Region", b =>
                {
                    b.Navigation("Districts");

                    b.Navigation("Students");

                    b.Navigation("Tyutors");
                });

            modelBuilder.Entity("AddStep.Models.Sport", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("AddStep.Models.Tyutor", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
