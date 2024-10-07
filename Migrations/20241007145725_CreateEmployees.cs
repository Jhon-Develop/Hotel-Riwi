using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Riwi.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "password",
                value: "AQAAAAIAAYagAAAAEKiHSWSYC8mq4ohqWvXPcMPvz4P49E0JHTYfyEBrWVTXvMKJvLnoFoGa6pURAwwsUQ==");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "password",
                value: "AQAAAAIAAYagAAAAEM8maZBzkAlxVdR8etTm4hBjf1nAcHHM5flEmor+lFeVSOXRfxR8E9/+K3wnJJfFdQ==");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "password",
                value: "AQAAAAIAAYagAAAAEMq9vf4sqKHoWQblAzeVWlLPqy3U0amSaOWURydmo7qsN9PPLoPoAhh+UMQePYGbiw==");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "password",
                value: "AQAAAAIAAYagAAAAEMlYFZGupc5OvFTFDlWvWuQWsJKg2bAuc6AnYpb9NPXSjP4VvqEWd/7BVubg9C5OQA==");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "password",
                value: "AQAAAAIAAYagAAAAEB9DsU3tYR5qr3LU5XDjHuFSw54t/FOcrnxhgTp82EiV8sJpBNe25MR75ZK2uYSnPA==");
        }
    }
}
