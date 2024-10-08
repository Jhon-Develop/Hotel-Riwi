﻿// <auto-generated />
using System;
using Hotel_Riwi.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel_Riwi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241007180329_FixTables")]
    partial class FixTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Hotel_Riwi.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<int>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("total_cost");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("Hotel_Riwi.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IndentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("indentification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            IndentificationNumber = "123456",
                            LastName = "Doe",
                            PasswordHash = "$2a$11$FWjvPu8xjGNpvR6WSi0hZOuQFR95hXN6mtIVtNtv/NClHhv8GrOi."
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            IndentificationNumber = "654321",
                            LastName = "Smith",
                            PasswordHash = "$2a$11$udd9zkcvscGW2GPoChg2xOBqrHpaR5UtgCPSYxoJDQ07rwJj6cb7."
                        },
                        new
                        {
                            Id = 3,
                            Email = "robert.brown@example.com",
                            FirstName = "Robert",
                            IndentificationNumber = "789012",
                            LastName = "Brown",
                            PasswordHash = "$2a$11$jN05.6h3S/XR5ZkzL4LuruzEqmMpLhxRHR2cf/D3.rk3Bj6JWWoqq"
                        },
                        new
                        {
                            Id = 4,
                            Email = "emily.davis@example.com",
                            FirstName = "Emily",
                            IndentificationNumber = "345678",
                            LastName = "Davis",
                            PasswordHash = "$2a$11$d3e.dISOwlW5NCc4axYXlOve38fWEqp.IUyAOqSjQ4YMKlqvBgu/W"
                        },
                        new
                        {
                            Id = 5,
                            Email = "asprillajhon73@gmail.com",
                            FirstName = "Jhon",
                            IndentificationNumber = "1013456232",
                            LastName = "Asprilla",
                            PasswordHash = "$2a$11$gEskfaUOYyMmOXXCdASGzOjmBRk.2CVfhn/alFD9.iznccCXuhL.m"
                        });
                });

            modelBuilder.Entity("Hotel_Riwi.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("Hotel_Riwi.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<byte>("MaxOccupancyPersons")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("max_occupancy_persons");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("room_type_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 29,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-9",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 46,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-6",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 16,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-6",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 13,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-3",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 47,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-7",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 19,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-9",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 39,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-9",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 37,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-7",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 10,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-10",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 20,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-10",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-3",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 34,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-4",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 25,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-5",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 18,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-8",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 50,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-10",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 1,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-1",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 38,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-8",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-5",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 40,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-10",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 14,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-4",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 31,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-1",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 6,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-6",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 42,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-2",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 35,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-5",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 27,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-7",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 26,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-6",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 43,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-3",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 12,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-2",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 17,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-7",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-4",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 32,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-2",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-9",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-5",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-2",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-8",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 36,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-6",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 28,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-8",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 48,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-8",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-3",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-2",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 41,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-1",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 44,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-4",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 21,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-1",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "R2-1",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 30,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-10",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            MaxOccupancyPersons = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "R1-7",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 45,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-5",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 33,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R4-3",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 49,
                            Availability = true,
                            MaxOccupancyPersons = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "R5-9",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 24,
                            Availability = true,
                            MaxOccupancyPersons = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "R3-4",
                            RoomTypeId = 3
                        });
                });

            modelBuilder.Entity("Hotel_Riwi.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("room_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A cozy basic room with a single bed, ideal for single travelers.",
                            Name = "Single Room"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Offers flexibility with two single beds or a double bed, perfect for couples or friends.",
                            Name = "Double Room"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Spacious and luxurious, with a king size bed and separate living room, ideal for those seeking comfort and exclusivity.",
                            Name = "Suite"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Designed for families, with extra space and several beds for a comfortable stay.",
                            Name = "Family Room"
                        });
                });

            modelBuilder.Entity("Hotel_Riwi.Models.Booking", b =>
                {
                    b.HasOne("Hotel_Riwi.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Riwi.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Riwi.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel_Riwi.Models.Room", b =>
                {
                    b.HasOne("Hotel_Riwi.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
