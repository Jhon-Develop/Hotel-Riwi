using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class FixTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "indentification_number",
                table: "guests",
                newName: "identification_number");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "start_date",
                table: "bookings",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "end_date",
                table: "bookings",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$FWjvPu8xjGNpvR6WSi0hZOuQFR95hXN6mtIVtNtv/NClHhv8GrOi.");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$udd9zkcvscGW2GPoChg2xOBqrHpaR5UtgCPSYxoJDQ07rwJj6cb7.");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$jN05.6h3S/XR5ZkzL4LuruzEqmMpLhxRHR2cf/D3.rk3Bj6JWWoqq");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$d3e.dISOwlW5NCc4axYXlOve38fWEqp.IUyAOqSjQ4YMKlqvBgu/W");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$gEskfaUOYyMmOXXCdASGzOjmBRk.2CVfhn/alFD9.iznccCXuhL.m");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "identification_number",
                table: "guests",
                newName: "indentification_number");

            migrationBuilder.AlterColumn<DateTime>(
                name: "start_date",
                table: "bookings",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "end_date",
                table: "bookings",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "password",
                value: "$2a$11$ft9KUvHBYsRamfckhfTHSOykNtrNXkJqZaLroGZzyA1yHb13gWTNC");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "password",
                value: "$2a$11$SJUZ7VGMGVRkriiCqsGnlOo5P.rQYxiXdbkvoh2Jh1y.dPVHNl.QG");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "password",
                value: "$2a$11$dmr6eHas6csNXFsOKXbmc.4bB2bgZR51owBEXcb5u73tL6HOETH5O");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "password",
                value: "$2a$11$oZrot7k.aJPGGgh8t7kkqeF9h17IU1i/6Yj6/.BaYza2d/YBaiJLO");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "password",
                value: "$2a$11$foiD5ytv87ycn9EhVAdyX.JFFiwmS/0kazq9lPL0w7NvOdPJ4XalC");
        }
    }
}
