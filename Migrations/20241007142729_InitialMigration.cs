using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    indentification_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    indentification_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    birthdate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_types", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    room_type_id = table.Column<int>(type: "int", nullable: false),
                    price_per_night = table.Column<double>(type: "double", nullable: false),
                    availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    max_occupancy_persons = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rooms_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_id = table.Column<int>(type: "int", nullable: false),
                    guest_id = table.Column<int>(type: "int", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    total_cost = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bookings_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_guests_guest_id",
                        column: x => x.guest_id,
                        principalTable: "guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "Id", "description", "name" },
                values: new object[,]
                {
                    { 1, "A cozy basic room with a single bed, ideal for single travelers.", "Single Room" },
                    { 2, "Offers flexibility with two single beds or a double bed, perfect for couples or friends.", "Double Room" },
                    { 3, "Spacious and luxurious, with a king size bed and separate living room, ideal for those seeking comfort and exclusivity.", "Suite" },
                    { 4, "Designed for families, with extra space and several beds for a comfortable stay.", "Family Room" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "Id", "availability", "max_occupancy_persons", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, (byte)1, 50.0, "R1-1", 1 },
                    { 2, true, (byte)1, 50.0, "R1-2", 1 },
                    { 3, true, (byte)1, 50.0, "R1-3", 1 },
                    { 4, true, (byte)1, 50.0, "R1-4", 1 },
                    { 5, true, (byte)1, 50.0, "R1-5", 1 },
                    { 6, true, (byte)1, 50.0, "R1-6", 1 },
                    { 7, true, (byte)1, 50.0, "R1-7", 1 },
                    { 8, true, (byte)1, 50.0, "R1-8", 1 },
                    { 9, true, (byte)1, 50.0, "R1-9", 1 },
                    { 10, true, (byte)1, 50.0, "R1-10", 1 },
                    { 11, true, (byte)2, 80.0, "R2-1", 2 },
                    { 12, true, (byte)2, 80.0, "R2-2", 2 },
                    { 13, true, (byte)2, 80.0, "R2-3", 2 },
                    { 14, true, (byte)2, 80.0, "R2-4", 2 },
                    { 15, true, (byte)2, 80.0, "R2-5", 2 },
                    { 16, true, (byte)2, 80.0, "R2-6", 2 },
                    { 17, true, (byte)2, 80.0, "R2-7", 2 },
                    { 18, true, (byte)2, 80.0, "R2-8", 2 },
                    { 19, true, (byte)2, 80.0, "R2-9", 2 },
                    { 20, true, (byte)2, 80.0, "R2-10", 2 },
                    { 21, true, (byte)2, 150.0, "R3-1", 3 },
                    { 22, true, (byte)2, 150.0, "R3-2", 3 },
                    { 23, true, (byte)2, 150.0, "R3-3", 3 },
                    { 24, true, (byte)2, 150.0, "R3-4", 3 },
                    { 25, true, (byte)2, 150.0, "R3-5", 3 },
                    { 26, true, (byte)2, 150.0, "R3-6", 3 },
                    { 27, true, (byte)2, 150.0, "R3-7", 3 },
                    { 28, true, (byte)2, 150.0, "R3-8", 3 },
                    { 29, true, (byte)2, 150.0, "R3-9", 3 },
                    { 30, true, (byte)2, 150.0, "R3-10", 3 },
                    { 31, true, (byte)4, 200.0, "R4-1", 4 },
                    { 32, true, (byte)4, 200.0, "R4-2", 4 },
                    { 33, true, (byte)4, 200.0, "R4-3", 4 },
                    { 34, true, (byte)4, 200.0, "R4-4", 4 },
                    { 35, true, (byte)4, 200.0, "R4-5", 4 },
                    { 36, true, (byte)4, 200.0, "R4-6", 4 },
                    { 37, true, (byte)4, 200.0, "R4-7", 4 },
                    { 38, true, (byte)4, 200.0, "R4-8", 4 },
                    { 39, true, (byte)4, 200.0, "R4-9", 4 },
                    { 40, true, (byte)4, 200.0, "R4-10", 4 },
                    { 41, true, (byte)4, 200.0, "R5-1", 4 },
                    { 42, true, (byte)4, 200.0, "R5-2", 4 },
                    { 43, true, (byte)4, 200.0, "R5-3", 4 },
                    { 44, true, (byte)4, 200.0, "R5-4", 4 },
                    { 45, true, (byte)4, 200.0, "R5-5", 4 },
                    { 46, true, (byte)4, 200.0, "R5-6", 4 },
                    { 47, true, (byte)4, 200.0, "R5-7", 4 },
                    { 48, true, (byte)4, 200.0, "R5-8", 4 },
                    { 49, true, (byte)4, 200.0, "R5-9", 4 },
                    { 50, true, (byte)4, 200.0, "R5-10", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_employee_id",
                table: "bookings",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_guest_id",
                table: "bookings",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_room_id",
                table: "bookings",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_room_type_id",
                table: "rooms",
                column: "room_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "room_types");
        }
    }
}
