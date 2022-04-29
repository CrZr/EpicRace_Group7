﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("App.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("App.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Admin")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("App.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StartHour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("App.Models.RaceResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RaceId")
                        .IsUnique();

                    b.ToTable("RaceResults");
                });

            modelBuilder.Entity("App.Models.ResultItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RaceResultId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RaceResultId");

                    b.ToTable("ResultItems");
                });

            modelBuilder.Entity("App.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("BuildYear")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CategoryRace", b =>
                {
                    b.Property<int>("AuhtorizedCategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("RacesId")
                        .HasColumnType("int");

                    b.HasKey("AuhtorizedCategoriesId", "RacesId");

                    b.HasIndex("RacesId");

                    b.ToTable("RacesCategories", (string)null);
                });

            modelBuilder.Entity("CategoryVehicle", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("VehiclesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "VehiclesId");

                    b.HasIndex("VehiclesId");

                    b.ToTable("VehiclesCategories", (string)null);
                });

            modelBuilder.Entity("PilotRace", b =>
                {
                    b.Property<int>("PilotsId")
                        .HasColumnType("int");

                    b.Property<int>("RacesId")
                        .HasColumnType("int");

                    b.HasKey("PilotsId", "RacesId");

                    b.HasIndex("RacesId");

                    b.ToTable("PilotRace");
                });

            modelBuilder.Entity("PilotVehicle", b =>
                {
                    b.Property<int>("PilotsId")
                        .HasColumnType("int");

                    b.Property<int>("VehiclesId")
                        .HasColumnType("int");

                    b.HasKey("PilotsId", "VehiclesId");

                    b.HasIndex("VehiclesId");

                    b.ToTable("PilotVehicle");
                });

            modelBuilder.Entity("App.Models.RaceResult", b =>
                {
                    b.HasOne("App.Models.Race", "Race")
                        .WithOne("Result")
                        .HasForeignKey("App.Models.RaceResult", "RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("App.Models.ResultItem", b =>
                {
                    b.HasOne("App.Models.RaceResult", null)
                        .WithMany("ResultItems")
                        .HasForeignKey("RaceResultId");
                });

            modelBuilder.Entity("CategoryRace", b =>
                {
                    b.HasOne("App.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("AuhtorizedCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Race", null)
                        .WithMany()
                        .HasForeignKey("RacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategoryVehicle", b =>
                {
                    b.HasOne("App.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehiclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PilotRace", b =>
                {
                    b.HasOne("App.Models.Pilot", null)
                        .WithMany()
                        .HasForeignKey("PilotsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Race", null)
                        .WithMany()
                        .HasForeignKey("RacesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PilotVehicle", b =>
                {
                    b.HasOne("App.Models.Pilot", null)
                        .WithMany()
                        .HasForeignKey("PilotsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Models.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehiclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Models.Race", b =>
                {
                    b.Navigation("Result");
                });

            modelBuilder.Entity("App.Models.RaceResult", b =>
                {
                    b.Navigation("ResultItems");
                });
#pragma warning restore 612, 618
        }
    }
}
