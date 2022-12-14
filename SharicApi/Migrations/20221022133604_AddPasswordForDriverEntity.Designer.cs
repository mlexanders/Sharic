// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharicApi;

#nullable disable

namespace SharicApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221022133604_AddPasswordForDriverEntity")]
    partial class AddPasswordForDriverEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("SharicApi.Controllers.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SharicCommon.Data.Difinitions.StateTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeOnboard")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeUnBoard")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StateTasks");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PeopleInn")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFree")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DriverId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateTaskId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TripId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("StateTaskId");

                    b.HasIndex("TripId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Road", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Distance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SourcePointId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetPointId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Roads");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AircraftType")
                        .HasColumnType("TEXT");

                    b.Property<string>("AirlanesCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Airport")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("GateNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParkNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("PassengerCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Terminal")
                        .HasColumnType("TEXT");

                    b.Property<int>("TripType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("SharicCommon.Data.Models.Issue", b =>
                {
                    b.HasOne("SharicCommon.Data.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharicCommon.Data.Difinitions.StateTask", "StateTask")
                        .WithMany()
                        .HasForeignKey("StateTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SharicCommon.Data.Models.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("StateTask");

                    b.Navigation("Trip");
                });
#pragma warning restore 612, 618
        }
    }
}
