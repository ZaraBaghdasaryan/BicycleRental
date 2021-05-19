﻿// <auto-generated />
using System;
using BicycleRental;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BicycleRental.Migrations
{
    [DbContext(typeof(BicycleRentalDBContext))]
    [Migration("20210421193937_BicycleRental")]
    partial class BicycleRental
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BicycleBooking", b =>
                {
                    b.Property<int>("BicyclesId")
                        .HasColumnType("int");

                    b.Property<int>("BookingsId")
                        .HasColumnType("int");

                    b.HasKey("BicyclesId", "BookingsId");

                    b.HasIndex("BookingsId");

                    b.ToTable("BicycleBooking");
                });

            modelBuilder.Entity("BicycleRental.Models.Bicycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Availability")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("BicycleBrandId")
                        .HasColumnType("int");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MakeYear")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasMaxLength(18)
                        .HasColumnType("int");

                    b.Property<int?>("RentalCenterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BicycleBrandId");

                    b.HasIndex("RentalCenterId");

                    b.ToTable("Bicycles");
                });

            modelBuilder.Entity("BicycleRental.Models.BicycleBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("BicycleId")
                        .HasColumnType("int");

                    b.Property<int?>("BicycleId1")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("BicycleId1");

                    b.ToTable("BicycleBrands");
                });

            modelBuilder.Entity("BicycleRental.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BicycleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ExtensionDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RentalDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("BicycleRental.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BicycleRental.Models.RentalCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("BicycleId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BicycleId");

                    b.ToTable("RentalCenters");
                });

            modelBuilder.Entity("BicycleBooking", b =>
                {
                    b.HasOne("BicycleRental.Models.Bicycle", null)
                        .WithMany()
                        .HasForeignKey("BicyclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Models.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BicycleRental.Models.Bicycle", b =>
                {
                    b.HasOne("BicycleRental.Models.BicycleBrand", "BicycleBrand")
                        .WithMany("Bicycles")
                        .HasForeignKey("BicycleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Models.RentalCenter", null)
                        .WithMany("Bicycles")
                        .HasForeignKey("RentalCenterId");

                    b.Navigation("BicycleBrand");
                });

            modelBuilder.Entity("BicycleRental.Models.BicycleBrand", b =>
                {
                    b.HasOne("BicycleRental.Models.Bicycle", "Bicycle")
                        .WithMany()
                        .HasForeignKey("BicycleId1");

                    b.Navigation("Bicycle");
                });

            modelBuilder.Entity("BicycleRental.Models.Booking", b =>
                {
                    b.HasOne("BicycleRental.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BicycleRental.Models.RentalCenter", b =>
                {
                    b.HasOne("BicycleRental.Models.Bicycle", "Bicycle")
                        .WithMany()
                        .HasForeignKey("BicycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bicycle");
                });

            modelBuilder.Entity("BicycleRental.Models.BicycleBrand", b =>
                {
                    b.Navigation("Bicycles");
                });

            modelBuilder.Entity("BicycleRental.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("BicycleRental.Models.RentalCenter", b =>
                {
                    b.Navigation("Bicycles");
                });
#pragma warning restore 612, 618
        }
    }
}
