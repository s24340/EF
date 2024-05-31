using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFsolution.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9233), new DateTime(2024, 8, 29, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 7, 30, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 9, 28, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 8, 29, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9300), new DateTime(2024, 6, 30, 19, 29, 3, 36, DateTimeKind.Local).AddTicks(9301) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 8, 29, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 7, 30, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4797), new DateTime(2024, 9, 28, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4802), new DateTime(2024, 8, 29, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 6, 30, 19, 28, 20, 818, DateTimeKind.Local).AddTicks(4807) });
        }
    }
}
