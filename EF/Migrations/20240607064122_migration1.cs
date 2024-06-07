using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFsolution.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 7, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9789), new DateTime(2024, 9, 5, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 7, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 8, 6, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 7, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9838), new DateTime(2024, 10, 5, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 7, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9842), new DateTime(2024, 9, 5, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 7, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9846), new DateTime(2024, 7, 7, 8, 41, 21, 714, DateTimeKind.Local).AddTicks(9848) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 8, 29, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1183), new DateTime(2024, 7, 30, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 9, 28, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1191), new DateTime(2024, 8, 29, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 5, 31, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1195), new DateTime(2024, 6, 30, 19, 39, 12, 864, DateTimeKind.Local).AddTicks(1196) });
        }
    }
}
